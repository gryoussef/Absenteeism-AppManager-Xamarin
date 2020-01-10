using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xproject.Models
{
    class Presence
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(Etudiant))]
        public Etudiant etudiant { get; set; }
        [ForeignKey(typeof(Lesson))]
        public Lesson lesson { get; set; }
        public int NbAbsence { get; set; }

    }
}
