using Practica1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage.xaml();
            {
                ///Content = new Stacklayout
                //{
                //VerticalOptions= LayputOptions.Center,
                //Children = {
                //      new label {
                //            XAlign = TextAligment.Center,
                //            Text = "Welcome to MyPA"
                //               }
                //            }
                //}
            };
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
