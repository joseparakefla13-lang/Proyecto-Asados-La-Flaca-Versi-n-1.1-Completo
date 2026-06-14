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
                         WHERE ClustomerCode = @Code";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", codigo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        


        public string GetNextCustomerCode()
        {

            string nextCode = "CLI001"; // valor inicial por defecto

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Trae el último código ordenado numéricamente
                string query = @"SELECT MAX(ClustomerCode) FROM Customer";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    string lastCode = result.ToString(); // ejemplo: CLI100
                    int number = int.Parse(lastCode.Substring(3)); // extrae los dígitos
                    number++;
                    nextCode = "CLI" + number.ToString("D3"); // CLI101
                }
            }

            return nextCode;
        }
        public int SaveCustomer(string codigo, string nombre, string telefono, string tipo, bool activo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Verificar si el cliente ya existe
                string checkQuery = "SELECT COUNT(*) FROM Customer WHERE ClustomerCode = @Code";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Code", codigo);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    // UPDATE
                    string updateQuery = @"UPDATE Customer
                                   SET CustomerName = @Name,
                                       Phone = @Phone,
                                       CustomerType = @Type,
                                       Available = @Available
                                   WHERE ClustomerCode = @Code";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@Clustomer", codigo);
                    updateCmd.Parameters.AddWithValue("@Name", nombre);
                    updateCmd.Parameters.AddWithValue("@Phone", telefono);
                    updateCmd.Parameters.AddWithValue("@Type", tipo);
                    updateCmd.Parameters.AddWithValue("@Available", activo);

                    return updateCmd.ExecuteNonQuery();
                }
                else
                {
                    // INSERT
                    string insertQuery = @"INSERT INTO Customer (ClustomerCode, CustomerName, Phone, CustomerType, Available)
                                   VALUES (@Code, @Name, @Phone, @Type, @Available)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Clustomer", codigo);
                    insertCmd.Parameters.AddWithValue("@Name", nombre);
                    insertCmd.Parameters.AddWithValue("@Phone", telefono);
                    insertCmd.Parameters.AddWithValue("@Type", tipo);
                    insertCmd.Parameters.AddWithValue("@Available", activo);

                    return insertCmd.ExecuteNonQuery();
                }
            }
        }
        public string GetCustomerNameByCode(string codigo)
        {
            string query = @"SELECT Names
                     FROM Customer
                     WHERE ClustomerCode = @codigo";

            SelectQuery select = new SelectQuery();

            // Usamos SqlParameter[] en lugar de Dictionary
            SqlParameter[] parameters = new SqlParameter[]
            {
             new SqlParameter("@codigo", codigo)
            };

            DataTable dt = select.ExecuteSelect(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Names"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }



        public int UpdateCustomer(string codigo, string nombre, string telefono, string tipo, bool activo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Customer
                         SET CustomerName = @Name,
                             Phone = @Phone,
                             CustomerType = @Type,
                             Available = @Available
                         WHERE ClustomerCode = @Code";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClustomerCode", codigo);
                cmd.Parameters.AddWithValue("@Name", nombre);
                cmd.Parameters.AddWithValue("@Phone", telefono);
                cmd.Parameters.AddWithValue("@Type", tipo);
                cmd.Parameters.AddWithValue("@Available", activo);

                return cmd.ExecuteNonQuery(); // devuelve filas afectadas
            }
        }

    }
}       


