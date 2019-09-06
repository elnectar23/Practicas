using Practica2.Data;
using Practica2.Menu;
using Practica2.Models;
using Practica2.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Practica2.Views
{
    public class PaginaListaContactos : MasterDetailPage
    {
        public PaginaListaContactos()
        {
            var lista = new ListView();
            lista.ItemsSource = 
                GeneradorDeContactos.
                CrearContactos().
                OrderBy(x => x.Nombre);

            lista.ItemSelected += (sender, e) =>
            {
                if(e.SelectedItem != null)
                {
                    Detail = new PaginaContacto(e.SelectedItem as Contacto);
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Contactos",
                Content = lista
            };
            Detail = new Views.Menu.PaginaContacto(GeneradorDeContactos.
                CrearContactos().First());

        }
        
    }

    internal class PaginaContacto : Page
    {
        private Contacto contacto;

        public PaginaContacto(Contacto contacto)
        {
            this.contacto = contacto;
        }
    }
}
