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
    class RegisterViewModel: INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged=delegate { };
        
       public  Boolean IsValidRegistrition { get; set; }
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
        public string username;
        public string Username {
            get { return username; }
            set {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Username)));
            }
        }
        public string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Password)));
            }
        }
        public string confirmation;
        public string Confirmation
        {
            get { return confirmation; }
            set
            {
                confirmation = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Confirmation)));
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
       

        public RegisterViewModel() {
            IsValidRegistrition = false;
        }
         public ICommand SubmitCommand {
            get {
                return new Command(() => {
                    OnSubmit();
                });
            }
        }

        

        public void OnSubmit() {

            if (!IsAnyEmptyField()) {
                if (IsValidPassword(Password)) {
                    if (IsMatchingPassword(Password,Confirmation)) {
                        if (IsValidEmail(Email)) {
                            if (!ProfesseurManipulation.IsExistedUsername(Username))
                            {
                                if (!ProfesseurManipulation.IsExistedEmail(Email))
                                {
                                    ProfesseurManipulation.Insert(Username, Password, Email);
                                    IsValidRegistrition = true;
                                    Message = " Your Registration Completed ";
                                    return;
                                }

                                Message = " Email already Existed ";
                                return;
                            }
                            Message = " Username already Existed ";
                            return;

                            
                        }
                        Message = "Enter a valid email address";
                        return;
                    }
                    Message = "Password and confirmation mismatch ";
                    return;
                }
                Message = "Enter a password of 8 characters  at least ";
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
        public bool IsValidPassword(String password) {
            if (password.Length<8)
            {
                return false;
            }
            return true;
        }
        public bool IsMatchingPassword(String pass, String conf)
        {
            var compare = pass.CompareTo(conf);
            if (compare == 0) {
                return true;
            }
            return false;

        }
        public Boolean IsAnyEmptyField() {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Confirmation) || string.IsNullOrWhiteSpace(Email)) {
                return true;
            }
            return false;
        }
        
    }
}
