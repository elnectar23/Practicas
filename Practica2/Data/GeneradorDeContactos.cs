using Practica2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Practica2.Data
{
    class GeneradorDeContactos
    {
        private static List<string> ListaNombres =
            new List<string>()
            {
                 "Carlos", "Elian", "Luis", "Sara", "Michael",
                 "Nelson", "Scarlet", "Alam", "Halid",
                 "Angel", "Pedro"
            };

        private static List<string> ListaApellidos =
            new List<string>()
            {
                "Gonzalez", "Vasquez", "Herasme", "Torres",
                "Jordan", "Peña", "Martinez", "Cabral", "Segura",
                "Pereyra", "Ricardo"
            };

        public static ObservableCollection<Contacto> CrearContactos()
        {
            var ramdom = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for(int i = 0; i <25; i++)
            {
                var nombre = ListaNombres[ramdom.Next(ListaNombres.Count - 1)];
                var apellido = ListaApellidos[ramdom.Next(ListaApellidos.Count - 1)];
                var calle = ListaNombres[ramdom.Next(ListaNombres.Count - 1)];
                var contacto = new Contacto
                {
                    Nombre = nombre + " " + apellido,
                    Telefono = GenerarTelefono(),
                    Direccion = "Avenida" + calle + ", Numero" + ramdom.Next(1, 1000)
                };
                contactos.Add(contacto);
            }
            return contactos;
        }

        private static string GenerarTelefono()
        {
            var random = new Random();
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(");
            telefono.Append(random.Next(100, 999));
            telefono.Append(")");
            telefono.Append(random.Next(1000000, 9999999));
            return telefono.ToString();
        }
    }
}
