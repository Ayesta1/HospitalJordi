using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalJordi
{
    internal class Departamento
    {
        List<Departamento> departamentos = new List<Departamento>();

        string nombreDepa;
        int telefonoDepa;
        int planta;

        public string NombreDepa { get => nombreDepa; set => nombreDepa = value; }
        public int TelefonoDepa { get => telefonoDepa; set => telefonoDepa = value; }
        public int Planta { get => planta; set => planta = value; }

        public Departamento(string nombreDepa, int telefonoDepa, int planta)
        {
            this.nombreDepa = nombreDepa;
            this.telefonoDepa = telefonoDepa;
            this.planta = planta;
        }



    }
}
