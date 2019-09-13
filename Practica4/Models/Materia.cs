using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4.Models
{
    public class Materia
    {   
            public string Materias{ get; set; }
            public string Codigo { get; set; }
            public string Aula { get; set; }
            public string Profesores { get; set; }
            public string Seccion { get; set; }
            public string HorarioDias { get; set; }
            public string HorarioHoras { get; set; }
            

            public override string ToString()
            {
                return Materias;
            }

        }
    }
