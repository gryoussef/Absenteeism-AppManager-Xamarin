using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xproject.Models;

namespace Xproject.Data
{
    class EtudiantManipulation
    {
        public static void Insert(int cne, string nom, string prenom, string email, string tele, string filiere)
        {

            var db = SqliteDB.connect();
            var newEtudiant = new Etudiant();
            newEtudiant.Cne = cne;
            newEtudiant.Nom = nom;
            newEtudiant.Prenom = prenom;
            newEtudiant.Email = email;
            newEtudiant.Telephone = tele;
            newEtudiant.Filiere = filiere;
            db.Insert(newEtudiant);
            db.Close();

        }
        public static List<Etudiant> GetAllStudent()
        {
            var db = SqliteDB.connect();
            List<Etudiant> allStudent= db.Table<Etudiant>().OrderBy(x => x.Id).ToList();
            db.Close();
            return allStudent;
        }
        public static List<Etudiant> GetAllFiliere()
        {
            var db = SqliteDB.connect();
            return db.Query<Etudiant>("select Filiere from Etudiant").ToList();
           
        }
    }
}
