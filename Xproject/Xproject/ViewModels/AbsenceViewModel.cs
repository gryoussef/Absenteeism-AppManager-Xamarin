using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xproject.Models;

using Xproject.Data;

namespace Xproject.ViewModels
{
    class AbsenceViewModel
    {
        public ObservableCollection<Etudiant> StudentList { get; set; }
        public List<string> filiere;
        public AbsenceViewModel() {
            StudentList = new ObservableCollection<Etudiant>(EtudiantManipulation.GetAllStudent());
            filiere = new List<string>();
            filiere.Add("informatique");
            filiere.Add("induse");
            filiere.Add("telecome");
        }
    }
}
