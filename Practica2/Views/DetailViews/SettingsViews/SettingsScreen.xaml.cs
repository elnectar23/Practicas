﻿using Practica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica2.Views.DetailViews.SettingsViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica2.Views.DetailViews.SettingsViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsScreen : ContentPage
    {
        Settings settings;
        SwitchCell switchCell1;
        SwitchCell switchCell2;
        //User currentuser;
        public SettingsScreen()
        {
            InitializeComponent();
            BackgroundColor = Constants.BackgroundColor;
            loadSettings();
            App.StartCheckIfInternet(lbl_NoInternet, this);
            Title = Constants.SettingsScreenTitle;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.StartCheckIfInternet(lbl_NoInternet, this);
        }
        private void loadSettings()
        {
            settings = App.SettingsDataBase.GetSettings();
            //currentuser = App.UserDatabase.GetUser();

            TableView table;

            SwitchCell switchCell1 = new SwitchCell
            {
                Text = "SwitchCell 1",
                On = settings.switch1
            };

            switchCell1.OnChanged += (object sender, ToggledEventArgs e) =>
            {
                SwitchCell1Switched(sender, e);
            };

            SwitchCell switchCell2 = new SwitchCell
            {
                Text = "SwitchCell 2",
                On = settings.switch2
            };

            switchCell2.OnChanged += (object sender, ToggledEventArgs e) =>
            {
                SwitchCell2Switched(sender, e);
            };

            table = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection
                    {
                        switchCell1,
                        switchCell2
                    }
                }
            };

            table.VerticalOptions = LayoutOptions.FillAndExpand;

            MainLayout.Children.Add(table);

        }

        private void SwitchCell1Switched(object sender, ToggledEventArgs e)
        {
            settings.switch1 = e.Value;
        }

        private void SwitchCell2Switched(object sender, ToggledEventArgs e)
        {
            settings.switch2 = e.Value;
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            var action = await DisplayAlert("Settings", "Do you want to save the settings?", "save", "cancel");
            if(action)
            SaveSettings();
        }

        private void SaveSettings()
        {
            App.SettingsDataBase.SaveSettings(settings);
        }
    }
}