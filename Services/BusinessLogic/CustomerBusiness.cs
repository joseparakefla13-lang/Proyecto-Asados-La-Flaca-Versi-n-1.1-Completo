using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic
{
    internal class CustomerBusiness
    {
        /// <summary>
        /// Inserta un cliente en la base de datos aplicando reglas de negocio:
        /// - Código único
        /// - Cliente activo
        /// - Fecha de registro válida
        /// </summary>
        public int InsertCustomer(Customer newCustomer)
        {
            // 1. Validar que el código sea único
            bool esUnico = newCustomer.IsUniqueCustomerCode(newCustomer.ClustomerCode);
            if (!esUnico)
            {
                throw new Exception("El código de cliente ya existe en la base de datos.");
            }

            // 2. Validar que el cliente esté activo
            if (!newCustomer.Available)
            {
                throw new Exception("El cliente debe estar activo para poder registrarse.");
            }

            // 3. Validar que la fecha de registro no sea futura
            if (!newCustomer.ValidateCurrentDate())
            {
                throw new Exception("La fecha de registro no puede ser futura.");
            }

            // 4. Si pasa las validaciones, insertar en la BD
            return newCustomer.InsertCustomer();
        }

     
    }
}