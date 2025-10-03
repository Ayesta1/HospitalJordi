using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalJordi
{
    internal class Medico : Persona
    {
        string especialidad;

        public Medico(string nombre, string apellido, int edad) : base(nombre, apellido, edad)
        {
        }
    }
}
