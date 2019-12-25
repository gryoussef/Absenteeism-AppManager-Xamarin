using System;
using System.Collections.Generic;
using System.Text;
using Xproject.Models;

namespace Xproject.Data
{
    class ProfesseurManipulation
    {
        public static void Insert(string username,string password,string email)
        {

            var db = SqliteDB.connect();
            var newProfesseur = new Professeur();
            newProfesseur.Username = username;
            newProfesseur.Password = password;
            newProfesseur.Email = email;
            db.Insert(newProfesseur);
            db.Close();

        }
        public static Boolean Login(string username, string password) {
            var db = SqliteDB.connect();
            var data = db.Table<Professeur>();
            var d1 = data.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            db.Close();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;
            
        }
        public static Boolean IsExistedUsername(string username)
        {
            var db = SqliteDB.connect();
            var data = db.Table<Professeur>();
            var d1 = data.Where(x => x.Username == username ).FirstOrDefault();
            db.Close();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;

        }
        public static Boolean IsExistedEmail(string email)
        {
            var db = SqliteDB.connect();
            var data = db.Table<Professeur>();
            var d1 = data.Where(x => x.Email == email).FirstOrDefault();
            db.Close();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;

        }

    }
}
