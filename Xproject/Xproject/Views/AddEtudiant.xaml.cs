using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xproject.ViewModels;

namespace Xproject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEtudiant : ContentPage
    {
        AddEtudiantViewModel AddEtudiantVM;
        public AddEtudiant()
        {
            InitializeComponent();
            AddEtudiantVM = new AddEtudiantViewModel();
            this.BindingContext = AddEtudiantVM;
        }

      

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
             await Navigation.PopAsync();
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            if (AddEtudiantVM.IsValidAddition)
            {
                await DisplayAlert("Message", "Etudiant ajoutée", "OK");
                await Navigation.PopAsync();
            }
        }
    }
}