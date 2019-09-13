using Practica4.Api_Service;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica4
{
    public partial class App : Application
    {
       
        static ApiService ApiService;
        private static Label labelScreen;
        private static bool hasInternet;
        private static Page currentpage;

        internal static void StartCheckIfInternet(Label lbl_NoInternet )
        {
            throw new NotImplementedException();
        }

        private static bool noInterShow;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
