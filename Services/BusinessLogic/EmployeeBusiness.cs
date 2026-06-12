using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic
{
    internal class EmployeeBusiness
    {

        private readonly string connectionString =
            "Server=COQUETO;Database=Dev_Asado2.sql;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";

        // Generar el siguiente código disponible (EMP###)
        public string GetNextEmployeeCode()
        {
            string nextCode = "EMP001";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT TOP 1 EmployeeCode 
                             FROM Employee 
                             ORDER BY EmployeeCode DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastCode = result.ToString(); // ejemplo: EMP100
                    int number = int.Parse(lastCode.Substring(3));
                    number++;
                    nextCode = "EMP" + number.ToString("D3");
                }
            }
            return nextCode;
        }
        // Actualizar empleado manteniendo el mismo código
        public int UpdateEmployee(Employee empleado)
        {
            if (string.IsNullOrEmpty(empleado.Names))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrEmpty(empleado.SurNames))
                throw new ArgumentException("Los apellidos son obligatorios.");
            if (string.IsNullOrEmpty(empleado.Position))
                throw new ArgumentException("Debe seleccionar un puesto laboral.");
            if (string.IsNullOrEmpty(empleado.Phone))
                throw new ArgumentException("El teléfono no puede estar vacío.");
            if (!System.Text.RegularExpressions.Regex.IsMatch(empleado.Phone, @"^\d{8}$"))
                throw new ArgumentException("El teléfono debe tener exactamente 8 dígitos.");
            if (!IsUniquePhoneForUpdate(empleado.Phone, empleado.EmployeeCode))
                throw new ArgumentException("El teléfono ya está registrado en otro empleado.");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Employee 
                         SET Names = @Names,
                             SurNames = @SurNames,
                             Position = @Position,
                             Phone = @Phone,
                             Available = @Available
                         WHERE EmployeeCode = @EmployeeCode";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeCode", empleado.EmployeeCode);
                cmd.Parameters.AddWithValue("@Names", empleado.Names);
                cmd.Parameters.AddWithValue("@SurNames", empleado.SurNames);
                cmd.Parameters.AddWithValue("@Position", empleado.Position);
                cmd.Parameters.AddWithValue("@Phone", empleado.Phone);
                cmd.Parameters.AddWithValue("@Available", empleado.Available);

                return cmd.ExecuteNonQuery();
            }
        }

        // Validar teléfono único pero permitiendo el mismo empleado
        private bool IsUniquePhoneForUpdate(string phone, string employeeCode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) 
                         FROM Employee 
                         WHERE Phone = @Phone AND EmployeeCode <> @EmployeeCode";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);

                int count = (int)cmd.ExecuteScalar();
                return count == 0;
            }
        }

        // Validar teléfono único
        public bool IsUniquePhone(string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Employee WHERE Phone = @Phone";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Phone", phone);
                int count = (int)cmd.ExecuteScalar();
                return count == 0;
            }
        }

        // Insertar empleado con reglas de negocio
        // Insertar empleado con reglas de negocio
        public int InsertEmployee(Employee empleado)
        {
            // Validar nombre obligatorio
            if (string.IsNullOrEmpty(empleado.Names))
                throw new ArgumentException("El nombre no puede estar vacío.");

            // Validar apellidos obligatorios
            if (string.IsNullOrEmpty(empleado.SurNames))
                throw new ArgumentException("Los apellidos son obligatorios.");

            // Validar puesto obligatorio
            if (string.IsNullOrEmpty(empleado.Position))
                throw new ArgumentException("Debe seleccionar un puesto laboral.");

            // Validar teléfono obligatorio
            if (string.IsNullOrEmpty(empleado.Phone))
                throw new ArgumentException("El teléfono no puede estar vacío.");

            // Validar formato de teléfono (8 dígitos)
            if (!System.Text.RegularExpressions.Regex.IsMatch(empleado.Phone, @"^\d{8}$"))
                throw new ArgumentException("El teléfono debe tener exactamente 8 dígitos.");

            // Validar teléfono único
            if (!IsUniquePhone(empleado.Phone))
                throw new ArgumentException("El teléfono ya está registrado.");

            // Validar que el código cumpla con formato EMP###
            if (!System.Text.RegularExpressions.Regex.IsMatch(empleado.EmployeeCode, @"^EMP\d{3}$"))
                throw new ArgumentException("El código debe tener formato EMP### (ejemplo: EMP001).");

            // Validar que esté activo
            if (!empleado.Available)
                throw new ArgumentException("El empleado debe estar marcado como activo.");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Employee 
                        (EmployeeCode, Names, SurNames, Position, Phone, Available) 
                        VALUES (@EmployeeCode, @Names, @SurNames, @Position, @Phone, @Available)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeCode", empleado.EmployeeCode);
                cmd.Parameters.AddWithValue("@Names", empleado.Names);
                cmd.Parameters.AddWithValue("@SurNames", empleado.SurNames);
                cmd.Parameters.AddWithValue("@Position", empleado.Position);
                cmd.Parameters.AddWithValue("@Phone", empleado.Phone);
                cmd.Parameters.AddWithValue("@Available", empleado.Available);

                return cmd.ExecuteNonQuery();
            }
        }


        // Buscar empleado por código
        public DataTable SearchEmployeeByCode(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
   
             conn.Open();
                string query = @"SELECT EmployeeCode, Names, SurNames, Position, Phone, Available 
                             FROM Employee
                             WHERE EmployeeCode = @EmployeeCode";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@EmployeeCode", codigo);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}



