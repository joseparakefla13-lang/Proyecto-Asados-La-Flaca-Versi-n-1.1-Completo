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
        /// Inserta un cliente aplicando reglas de negocio:
        /// - Código único
        /// - Fecha de registro válida (hoy)
        /// - Cliente activo
        /// </summary>
        public int InsertCustomer(Customer newCustomer)
        {
            // 1. Validar que el código sea único
            if (!newCustomer.IsUniqueCustomerCode(newCustomer.ClustomerCode))
            {
                throw new Exception("El código de cliente ya existe en la base de datos.");
            }

            // 2. Validar que la fecha de registro sea hoy
            if (!newCustomer.ValidateRegisterDate())
            {
                throw new Exception("La fecha de registro debe ser la del día actual.");
            }

            // 3. Validar que el cliente esté activo
            if (!newCustomer.Available)
            {
                throw new Exception("El cliente debe estar marcado como disponible.");
            }

            // 4. Insertar en BD
            return newCustomer.InsertCustomer();
        }

        /// <summary>
        /// Obtiene todos los clientes registrados
        /// </summary>
        public DataTable GetAllCustomers()
        {
            Customer c = new Customer();
            return c.GetAllCustomers();
        }

        /// <summary>
        /// Elimina un cliente por su código
        /// </summary>
        public int DeleteCustomer(string customerCode)
        {
            // Aquí puedes agregar validaciones antes de eliminar
            // Ejemplo: verificar si el cliente tiene pedidos activos
            return 0; // Pendiente de implementación
        }
    }

}
