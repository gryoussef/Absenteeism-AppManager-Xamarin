using System;
using System.Collections.Generic;
using System.Text;
using Xproject.Models;

namespace Xproject.Data
{
    class LessonManipulation
    {
        public static void Insert( string nom)
        {

            var db = SqliteDB.connect();
            var newLesson = new Lesson();
            newLesson.Nom = nom;
            db.Insert(newLesson);
            db.Close();

        }
    }
}
