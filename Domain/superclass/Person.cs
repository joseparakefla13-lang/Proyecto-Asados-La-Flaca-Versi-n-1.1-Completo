using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass
{
    internal abstract class Person
    {
         // Propiedades comunes
        public string ClustomerCode { get; set; }
        public string Names { get; set; }
        public string Phone { get; set; }
        public bool Available { get; set; }
        public DateTime RegistDate { get; set; }

        public Person()
        {
            // Constructor vacío para permitir la creación de objetos sin parámetros
        }

        // Constructor para inicializar todos los atributos
        public Person(string code, string names, string phone, bool available)
        {
            ClustomerCode = code;
            Names = names;
            Phone = phone;
            Available = available;
            RegistDate = DateTime.Today; // siempre se asigna la fecha actual
        }

        /// <summary>
        /// Valida que la fecha de registro sea exactamente la fecha de hoy.
        /// No permite fechas anteriores ni futuras.
        /// </summary>
        /// <returns>true si la fecha es hoy, false en cualquier otro caso</returns>
        public bool ValidateRegisterDate()
        {
            return RegistDate.Date == DateTime.Today;
        }

    }
}
