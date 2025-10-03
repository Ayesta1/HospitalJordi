using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalJordi
{
    internal class Program
    {
        private static List<Persona> Personas = new List<Persona>();
        static void Main(string[] args)
        {
            Departamento.CargarDepartamentos();
        }
    }
}
