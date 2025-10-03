using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalJordi
{
    public enum eTipoDolencia
    {
        /**
         * Problemas relacionados con lesiones físicas por accidentes o causas externas.
         */
        Traumatologia,

        /**
         * Problemas relacionados con el sistema circulatorio o el corazón.
         */
        Cardiologia,

        /**
         * Problemas relacionados con el sistema digestivo.
         */
        Gastroenterologia,

        /**
         * Problemas neurológicos.
         */
        Neurologia,

        /**
         * Problemas respiratorios.
         */
        Respiratorio,

        /**
         * Problemas ginecológicos u obstétricos.
         */
        ObstetriciaGinecologia,

        /**
         * Condiciones que no representan una emergencia y que idealmente 
         * deberían ser tratadas en consulta externa o centro de atención primaria.
         */
        NoEmergencia
    }
    internal class Paciente : Persona
    {
        public eTipoDolencia DolenciaActual { get; set; }
        public Paciente(string nombre, string apellido, int edad, eTipoDolencia tipoDolencia) : base(nombre, apellido, edad)
        {
            this.DolenciaActual = tipoDolencia;
        }
        public override string ToString()
        {
            return $"[PACIENTE] {Nombre} {Apellido}, {Edad} años. " +
               $"Motivo: {DolenciaActual.ToString().Replace("_", " ")}. ";
        }
    }
}
