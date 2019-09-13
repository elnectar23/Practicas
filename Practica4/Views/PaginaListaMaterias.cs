using Practica4.Data;
using Practica4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Practica4.Views
{
    public class PaginaListaMaterias 
    {
        public PaginaListaMaterias()
        {
            var lista = new ListView();
            lista.ItemsSource =
                GeneradorDeMaterias.
                CrearMaterias().
                OrderBy(x => x.Materia);

            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Models = new PaginaMateria(e.SelectedItem as Materia);
                    bool IsPresented = false;
                }
            };

            Views = new ContentPage
            {
                Title = "Materias",
                Content = lista
            };
            Models = new PaginaMateria(GeneradorDeMaterias.
                CrearMaterias().First());

        }

    }

    internal class PaginaMateria : Page
    {
        private Materia materia;

        public PaginaMateria(Materia materia)
        {
            this.materia = materia;
        }
    }

}
