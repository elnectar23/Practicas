﻿using Practica2.DetailViews;
using Practica2.Models;
using Practica2.Views.DetailViews;
using Practica2.Views.DetailViews.SettingsViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica2.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listview; } }
        public List<MasterMenuItem> items;

        public MasterPage()
        {
            InitializeComponent();
            SetItems();
        }

        void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("InfoScreen1", "icon.png", Color.White, typeof(InfoScreen1)));
            items.Add(new MasterMenuItem("InfoScreen2", "icon.png", Color.White, typeof(InfoScreen2)));
            items.Add(new MasterMenuItem("Settings", "icon.png", Color.White, typeof(SettingsScreen)));
            ListView.ItemsSource = items;

        }
    }
}