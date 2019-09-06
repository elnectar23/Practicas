using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica2.Menu1;

namespace Practica2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public object lbl_NoInternet { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            App.StartCheckIfInternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => Btn_Signin_Clicked (s, e);
        }

         async void Btn_Signin_Clicked(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckedInformation())
            {
                ActivitySpinner.IsVisible = true;
                var result = new Token();
                //var result = await App.RestService.Login(user);
                await DisplayAlert("Login", "Login Success", "Okay");

                if(App.SettingsDataBase.GetSettings() == null)
                {
                    Settings settings = new Models.Settings();
                    App.SettingsDataBase.SaveSettings(settings);
                }
                

                if (result.access_token != null) {
                    ActivitySpinner.IsVisible = false;
                    //App.UserDatabase.SaveUser(user);
                    //App.TokenDatabase.SaveToken(result);
                    if(Device.OS == TargetPlatform.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new MasterDetail());
                    }
                    else if(Device.OS == TargetPlatform.iOS)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new MasterDetail()));
                    }
                }
            }
            else
            {
                await DisplayAlert("Login", "Login Incorrect, empty Username or Password.", "Okay");
                ActivitySpinner.IsVisible = false;
            }

        }
    }
}