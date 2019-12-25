using Xproject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xproject.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public Boolean IsValidLogin { get; set; }
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
        public string Username
        {
            get { return username; }
            set
            {
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
        public ICommand LoginCommand
        {
            get
            {
                return new Command(() => {
                    OnLogin();
                });
            }
        }
        public LoginViewModel() {
            IsValidLogin = false;
        }
        public void OnLogin()
        {
            if (!IsAnyEmptyField())
            {
                if (ProfesseurManipulation.Login(Username, Password))
                {
                    IsValidLogin = true;
                    return;
                }
                Message = "Username or password is wrong !";
                return;
            }
            Message = "Enter all the required information";
            return;

        }
        public Boolean IsAnyEmptyField()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password) )
            {
                return true;
            }
            return false;
        }

    }
}
