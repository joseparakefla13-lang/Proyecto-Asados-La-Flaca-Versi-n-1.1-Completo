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

        public int InsertCustomer(Customer cliente)
        {

            if (string.IsNullOrEmpty(cliente.Phone))
                throw new ArgumentException("El teléfono no puede estar vacío.");
            if (string.IsNullOrEmpty(cliente.Names))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrEmpty(cliente.TypeCustomer))
                throw new ArgumentException("Debe seleccionar un tipo de cliente.");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Customer 
                         (ClustomerCode, Names, Phone, TypeCustomer, Available, RegistDate) 
                         VALUES (@ClustomerCode, @Names, @Phone, @TypeCustomer, @Available, @RegistDate)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClustomerCode", cliente.ClustomerCode);
                cmd.Parameters.AddWithValue("@Names", cliente.Names);
                cmd.Parameters.AddWithValue("@Phone", cliente.Phone);
                cmd.Parameters.AddWithValue("@TypeCustomer", cliente.TypeCustomer);
                cmd.Parameters.AddWithValue("@Available", cliente.Available); // ahora depende del CheckBox
                cmd.Parameters.AddWithValue("@RegistDate", cliente.RegistDate);

                return cmd.ExecuteNonQuery();
            }
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
        public DataTable SearchCustomerByCode(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT ClustomerCode, Names, Phone, TypeCustomer, Available, RegistDate 
                         FROM Customer
                         WHERE ClustomerCode = @ClustomerCode";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@ClustomerCode", codigo);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }


        public string GetNextEmployeeCode()
        {
            string nextCode = "EMP001"; // valor inicial por defecto

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Trae el último código ordenado numéricamente
                string query = @"SELECT TOP 1 EmployeeCode 
                         FROM Employee 
                         ORDER BY EmployeeCode DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    string lastCode = result.ToString(); // ejemplo: EMP010

                    // Extraer la parte numérica
                    int number = int.Parse(lastCode.Substring(3));

                    // Incrementar en 1
                    number++;

                    // Formatear con 3 dígitos
                    nextCode = "EMP" + number.ToString("D3");
                }
            }

            return nextCode;
        }
        public int UpdateEmployee(Employee emp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Employee 
                         SET Names = @Names,
                             SurNames = @SurNames,
                             Phone = @Phone,
                             Position = @Position,
                             Available = @Available
                         WHERE EmployeeCode = @Code";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", emp.EmployeeCode);
                cmd.Parameters.AddWithValue("@Names", emp.Names);
                cmd.Parameters.AddWithValue("@SurNames", emp.SurNames);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                cmd.Parameters.AddWithValue("@Position", emp.Position);
                cmd.Parameters.AddWithValue("@Available", emp.Available);

                return cmd.ExecuteNonQuery();
            }
        }


    }
}       


