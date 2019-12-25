using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xproject.Data;
namespace Xproject
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }

        SqliteDB database;
        public App()
        {
            InitializeComponent();
            database = new SqliteDB();
            
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Login());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
        }
      

        protected override void OnStart()
        {
          
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
