using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xproject.Views;

namespace Xproject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AddStudent_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEtudiant());
        }

        private async void Absence_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Absence());
        }

        private async  void NewLesson_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AjouterLesson());
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsenceEtudiant());
        }

        private void LogOut_Clicked(object sender, EventArgs e)
        {

        }
    }
}
