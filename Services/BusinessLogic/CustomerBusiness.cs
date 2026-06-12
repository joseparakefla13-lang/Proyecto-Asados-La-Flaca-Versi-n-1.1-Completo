using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic
{

    internal class CustomerBusiness
    {
        // Cadena de conexión definida dentro de la clase
        private readonly string connectionString =
            "Server=COQUETO;Database=Dev_Asado2.sql;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";

        /// <summary>
        /// Inserta un cliente aplicando reglas de negocio:
        /// - Código único
        /// - Fecha de registro válida (hoy)
        /// - Cliente activo
        /// </summary>
        /// 
        public bool IsValidRegisterDate(DateTime date)
        {
            // Solo se permite la fecha de hoy, ni antes ni después
            return date.Date == DateTime.Today;
        }

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
        public bool IsUniquePhone(string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Customer WHERE Phone = @Phone";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Phone", phone);

                int count = (int)cmd.ExecuteScalar();

                // Si count > 0, ya existe ese número
                return count == 0;
            }
        }

        public string GetNextCustomerCode()
        {
            string nextCode = "CLI001"; // valor inicial por defecto

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Trae el último código ordenado numéricamente
                string query = @"SELECT TOP 1 ClustomerCode 
                         FROM Customer 
                         ORDER BY ClustomerCode DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastCode = result.ToString(); // ejemplo: CLI100

                    // Extraer la parte numérica
                    int number = int.Parse(lastCode.Substring(3));

                    // Incrementar en 1
                    number++;

                    // Formatear con 3 dígitos
                    nextCode = "CLI" + number.ToString("D3");
                }
            }

            return nextCode;
        }
    }       

}
