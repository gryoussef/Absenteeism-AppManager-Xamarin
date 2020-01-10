using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xproject.Data;
using Xproject.ViewModels;

namespace Xproject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjouterLesson : ContentPage
    {
        AbsenceViewModel AbsenceVM;
        public AjouterLesson()
        {
            InitializeComponent();
            AbsenceVM = new AbsenceViewModel();
            this.BindingContext = AbsenceVM;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            LessonManipulation.Insert(Nom_Lesson.Text);
            await DisplayAlert("Message", "Lesson ajoutée", "OK");
        }
    }
}

