using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalJordi
{
    public enum eEspecialidadMedico
    {
        /**
         * Médico general o de triaje; maneja casos de baja complejidad y determina la derivación.
         */
        MedicinaGeneral,

        /**
         * Se ocupa de lesiones del sistema musculoesquelético (huesos, articulaciones, músculos).
         * Corresponde a Traumatologia.
         */
        Traumatologia,

        /**
         * Especialista en el corazón y el sistema circulatorio.
         * Corresponde a Cardiologia.
         */
        Cardiologia,

        /**
         * Especialista en el sistema digestivo.
         * Corresponde a Gastroenterologia.
         */
        Gastroenterologia,

        /**
         * Especialista en el sistema nervioso central y periférico.
         * Corresponde a Neurologia.
         */
        Neurologia,

        /**
         * Especialista en el sistema respiratorio (pulmones y vías respiratorias).
         * Corresponde a Respiratorio.
         */
        Neumologia, // Nota: "Neumología" es el término médico para la especialidad respiratoria.

        /**
         * Especialista en el sistema reproductor femenino y el embarazo/parto.
         * Corresponde a ObstetriciaGinecologia.
         */
        GinecologiaObstetricia,

        /**
         * Especialista en la atención inmediata de pacientes críticos con cualquier tipo de emergencia.
         * Adecuado para casos de EmergenciaVital y UrgenciaGrave.
         */
        MedicinaDeEmergencias
    }
    internal class Medico : Persona
    {

        public eEspecialidadMedico Especialidad { get; set; }

        public Medico(string nombre, string apellido, int edad, eEspecialidadMedico especialidad)
            : base(nombre, apellido, edad)
        {
            this.Especialidad = especialidad;
        }
    }
}
