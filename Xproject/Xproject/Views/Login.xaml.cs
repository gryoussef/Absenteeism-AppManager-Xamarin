using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xproject.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xproject.ViewModels;

namespace Xproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        LoginViewModel LoginVM;
        public Login()
        {
            InitializeComponent();
            LoginVM = new LoginViewModel();
            this.BindingContext = LoginVM;


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (LoginVM.IsValidLogin)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await DisplayAlert("Loge In", "You've successfully logged in  ", "OK");
                await Navigation.PopAsync();
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
    }
}