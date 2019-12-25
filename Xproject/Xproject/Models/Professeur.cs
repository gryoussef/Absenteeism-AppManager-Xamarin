﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xproject.Models
{
    [Table("Professeur")]
    public class Professeur
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
