using Practica4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Practica4.Data
{
    class GeneradorDeMaterias
    {
        private static List<string> ListaMaterias =
            new List<string>()
            {
                "Laboratorio de Bases de datos I", "Bases de datos I", "Desarrollo movil", "Calculo Integral"
            };

        private static List<string> ListaCodigo =
            new List<string>()
            {
                "INS381", "INS380", "IDS346", "CBM203"
            };

        private static List<string> ListaAula =
            new List<string>()
            {
                "FD-411", "GC-303", "FD-405", "GC-211"
            };

        private static List<string> ListaProfesores =
            new List<string>()
            {
                "Joel Jimenez", "Charlin Agramonte", "Randy Leonardo"
            };

        private static List<string> ListaSeccion =
            new List<string>()
            {
                "1", "2"
            };

        private static List<string> ListaHorarioDias =
            new List<string>()
            {
                "Martes", "Viernes", "Lunes,Miercoles,Viernes"
            };

        private static List<string> ListaHorarioHora =
            new List<string>()
            {
                "11am/1pm", "7am/9am", "6pm/10pm", "9am/11am"
            };

        public static ObservableCollection<Materia> CrearMaterias()
        {
            var ramdom = new Random();
            var materias = new ObservableCollection<Materia>();
            for (int i = 0; i < 25; i++)
            {
                var materia = ListaMaterias[ramdom.Next(ListaMaterias.Count - 1)];
                var codigo = ListaCodigo[ramdom.Next(ListaCodigo.Count - 1)];
                var aula = ListaMaterias[ramdom.Next(ListaMaterias.Count - 1)];
                var profesores = new Materia();
            }
        }
    }
}

