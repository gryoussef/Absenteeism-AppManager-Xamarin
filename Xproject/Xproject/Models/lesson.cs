using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xproject.Models
{
    [Table("Lesson")]
    class Lesson
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Nom { get; set; }

        

    }
}
