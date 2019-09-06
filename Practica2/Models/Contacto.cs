using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace Practica2.Models
{
    public class Contacto 
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }

    }
}
