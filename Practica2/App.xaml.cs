using System;
using Practica2.Data;
using Practica2.Views;
using Practica2.Models;
using Xamarin.Forms;
using System.Threading;
using Practica2.Views.DetailViews.SettingsViews;

namespace Practica2
{

    public partial class App : Application
    {
        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;
        static SettingsDataBaseController settingsDataBase;

        static RestService restService;
        private static Label labelScreen;
        private static bool hasInternet;
        private static Page currentpage;
        private static Timer timer;

        internal static void StartCheckIfInternet(Label lbl_NoInternet, MasterMenuItem masterMenuItem)
        {
            throw new NotImplementedException();
        }

        internal static void StartCheckIfInternet(Label lbl_NoInternet, SettingsScreen settingsScreen)
        {
            throw new NotImplementedException();
        }

        private static bool noInterShow;
            public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
            
        }

        
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        internal static void StartCheckIfInternet(object lbl_NoInternet, LoginPage loginPage)
        {
            throw new NotImplementedException();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        public static UserDatabaseController UserDatabase
        {
            get
            {
                if(userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }

        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }
        }

        public static SettingsDataBaseController SettingsDataBase
        {
            get
            {
                if(settingsDataBase == null)
                {
                    settingsDataBase = new SettingsDataBaseController();
                }
                return settingsDataBase;
            }
        }
        public static RestService RestService
        {
            get
            {
                if(restService == null)
                {
                    restService = new RestService();
                }
                return restService;
            }
        }
    }
}
