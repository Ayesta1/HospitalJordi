using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalJordi
{
    internal class Departamento
    {
        // Diccionario estático para almacenar todas las instancias de Departamento.
        // La clave es la Especialidad, y el valor es la instancia del Departamento.
        private static readonly Dictionary<eEspecialidadMedico, Departamento> Repositorio =
            new Dictionary<eEspecialidadMedico, Departamento>();

        // Propiedades de la instancia del Departamento
        public eEspecialidadMedico EspecialidadAsociada { get; }
        public string Nombre { get; }
        public int Telefono { get; set; }
        public int Planta { get; }

        // Constructor privado para asegurar que solo la clase pueda crear instancias,
        // garantizando que se agreguen al repositorio.
        private Departamento(eEspecialidadMedico especialidad, string nombre, int telefono, int planta)
        {
            this.EspecialidadAsociada = especialidad;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Planta = planta;
        }

        // --- MÉTODOS ESTÁTICOS DE GESTIÓN (REEMPLAZAN LA CLASE EXTENSION) ---

        /**
         * Inicializa y carga todos los departamentos del hospital.
         * ESTE MÉTODO DEBE LLAMARSE UNA VEZ AL INICIO DEL PROGRAMA.
         */
        public static void CargarDepartamentos()
        {
            // Limpiamos por si acaso, aunque static readonly solo se inicializa una vez
            Repositorio.Clear();

            // Creación y almacenamiento de los departamentos
            Repositorio.Add(eEspecialidadMedico.MedicinaDeEmergencias, new Departamento(eEspecialidadMedico.MedicinaDeEmergencias, "Sala de Urgencias (Triaje)", 987654321, 0));
            Repositorio.Add(eEspecialidadMedico.MedicinaGeneral, new Departamento(eEspecialidadMedico.MedicinaGeneral, "Consultas Externas", 987111222, 1));
            Repositorio.Add(eEspecialidadMedico.Gastroenterologia, new Departamento(eEspecialidadMedico.Gastroenterologia, "Digestivo", 987111333, 2));
            Repositorio.Add(eEspecialidadMedico.Traumatologia, new Departamento(eEspecialidadMedico.Traumatologia, "Cirugía Ortopédica y Traumatología", 987111444, 3));
            Repositorio.Add(eEspecialidadMedico.Cardiologia, new Departamento(eEspecialidadMedico.Cardiologia, "Unidad de Cardiología", 987111555, 4));
            Repositorio.Add(eEspecialidadMedico.Neumologia, new Departamento(eEspecialidadMedico.Neumologia, "Unidad Respiratoria", 987111666, 4)); 
            Repositorio.Add(eEspecialidadMedico.Neurologia, new Departamento(eEspecialidadMedico.Neurologia, "Neurociencias", 987111777, 5));
            Repositorio.Add(eEspecialidadMedico.GinecologiaObstetricia, new Departamento(eEspecialidadMedico.GinecologiaObstetricia, "Maternidad y Ginecología", 987111888, 6));
        }

        // Método principal para obtener la información de un departamento por su especialidad. 
        public static Departamento ObtenerPorEspecialidad(eEspecialidadMedico especialidad)
        {
            if (Repositorio.ContainsKey(especialidad))
            {
                return Repositorio[especialidad];
            }
            return new Departamento((eEspecialidadMedico)(-1), "Departamento No Encontrado", 0, -1);
        }

        // Método ToString() de la clase Departamento
        public override string ToString()
        {
            return $"{Nombre} ({EspecialidadAsociada}) en Planta {Planta}. Teléfono: {Telefono}";
        }
    }
}