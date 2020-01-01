using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Mail;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xproject.Data;

namespace Xproject.ViewModels
{
    class AddEtudiantViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public Boolean IsValidAddition { get; set; }

        string message { get; set; }
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Message)));
            }
        }
        public string cne;
        public string Cne
        {
            get { return cne; }
            set
            {
                cne = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Cne)));
            }
        }
        public string nom;

        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Nom)));
            }
        }
        public string prenom;
        public string Prenom
        {
            get { return prenom; }
            set
            {
                prenom = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Prenom)));
            }
        }
        public string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        }
        public string telephone;
        public string Telephone
        {
            get { return telephone; }
            set
            {
                telephone = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Telephone)));
            }
        }
        public string filiere;
        public string Filiere
        {
            get { return filiere; }
            set
            {
                filiere = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Filiere)));
            }
        }

        public AddEtudiantViewModel()
        {
            IsValidAddition = false;
        }
        public ICommand SubmitCommand
        {
            get
            {
                return new Command(() => {
                    OnSubmit();
                });
            }
        }



        public void OnSubmit()
        {
            if (!IsAnyEmptyField())
            {
                if (IsValideCne(Cne))
                {
                   
                        if (IsValidEmail(Email))
                        {
                        EtudiantManipulation.Insert(Int32.Parse(Cne),Nom,Prenom,Email,Telephone,Filiere);
                        IsValidAddition = true;
                        Message = " Your Registration Completed ";
                        return;
                    }
                        Message = "Enter a valid email address";
                        return;
                  
                }
                Message = "Enter a valid Cne ";
                return;

            }
            Message = "Enter all the required information";
            return;
        }
        public bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
      
     
        public Boolean IsAnyEmptyField()
        {
            if (string.IsNullOrWhiteSpace(Cne) || string.IsNullOrWhiteSpace(Nom) || string.IsNullOrWhiteSpace(Prenom) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Telephone) || string.IsNullOrWhiteSpace(Filiere))
            {
                return true;
            }
            return false;
        }
        public Boolean IsValideCne(string cne)
        {
            int nb = 0;
            if (int.TryParse(cne,out nb))
            {
                return true;
            }
            return false;

        }

    }
}
