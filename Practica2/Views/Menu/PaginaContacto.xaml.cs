﻿using Practica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica2.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaContacto : ContentPage
    {
        public PaginaContacto(Contacto contacto)
        {
            InitializeComponent();
            BackgroundColor = Color.FromRgb(48, 63, 159);
            BindingContext = contacto;
        }
    }
}