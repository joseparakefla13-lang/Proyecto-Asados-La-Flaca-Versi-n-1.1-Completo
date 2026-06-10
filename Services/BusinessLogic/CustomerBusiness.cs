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
            /// </summary>
            public int InsertCustomer(Customer newCustomer)
            {
                 // 1. Validar que el código sea único
                 bool existeCodigo = newCustomer.IsUniqueCustomerCode(newCustomer.CustomerCode);
                if (existeCodigo)
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

        /// <summary>
        /// Recupera un cliente por su ID
        /// </summary>
        /// 
        public DataTable ListCustomers()
        {
            Customer c = new Customer();
            return c.GetAllCustomers();
        }

        public void ReadCustomer()
        {
               
        }

            /// <summary>
            /// Lista de clientes (pendiente de implementación con paginación)
            /// </summary>
            public List<Customer> ListCustomers(int pageNumber)
            {
                return new List<Customer>(); // Aquí podrías implementar la consulta con paginación
            }

            /// <summary>
            /// Actualiza un cliente existente
            /// </summary>
            public int UpdateCustomer(Customer updatedCustomer)
            {
                // Aquí iría la lógica de negocio antes de actualizar
                return 0; // Pendiente de implementación
            }

            /// <summary>
            /// Elimina un cliente por su código
            /// </summary>
            public int DeleteCustomer(string customerCode)
            {
                // Aquí iría la lógica de negocio antes de eliminar
                return 0; // Pendiente de implementación
            }
    }
 }






