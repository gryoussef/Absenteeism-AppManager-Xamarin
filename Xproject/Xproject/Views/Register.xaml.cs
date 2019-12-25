using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xproject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        RegisterViewModel RegisterVM;
        public Register()
        {
            InitializeComponent();
            RegisterVM = new RegisterViewModel();
            this.BindingContext = RegisterVM;
           


        }

        private async  void Button_Clicked(object sender, EventArgs e)
        {
            if (RegisterVM.IsValidRegistrition) {

                await DisplayAlert("Registration", "You succesfully registred", "OK");
                await Navigation.PopAsync();
            }
        }
    }
}