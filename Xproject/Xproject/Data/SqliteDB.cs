using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xproject.Models;
namespace Xproject.Data
{
    class SqliteDB

    {
        public static string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"StudentsManagement.db3");

        public SqliteDB()
        {
            //Creating database, if it doesn't already exist 
            if (!File.Exists(dbPath))
            {
                var db = new SQLiteConnection(dbPath);
                db.CreateTable<Professeur>();
                db.CreateTable<Etudiant>();
                db.CreateTable<Lesson>();
                db.Close();

            }
            
        }
        public static SQLiteConnection connect()
        {
            var conn = new SQLiteConnection(dbPath);
            return conn;
        }
    }
}
