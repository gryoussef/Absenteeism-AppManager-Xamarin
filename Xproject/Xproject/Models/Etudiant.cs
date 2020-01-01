using SQLite;


namespace Xproject.Models
{
    [Table("Etudiant")]
     public class Etudiant
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Cne { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public string Filiere { get; set; }
    }
}
