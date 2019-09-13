using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica4.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Practica4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaMateria : ContentPage
    {
        public PaginaMateria()
        {
            InitializeComponent();
            BackgroundColor = Color.FromRgb(48, 63, 159);
            BindingContext = materia;
        }
    }
}