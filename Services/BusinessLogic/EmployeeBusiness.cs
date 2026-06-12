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

        // Obtener todos los empleados (para DataGridView)
        public DataTable GetAllEmployees()
        {
            string sql = @"SELECT EmployeeCode, Names, SurNames, Position, Phone, Available 
                       FROM Employee";

            using SelectQuery select = new SelectQuery();
            DataTable dt = select.ExecuteSelect(sql, null);
            return dt;
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
        public int InsertEmployee(Employee empleado)
        {
            if (string.IsNullOrEmpty(empleado.Names))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrEmpty(empleado.SurNames))
                throw new ArgumentException("Los apellidos son obligatorios.");
            if (string.IsNullOrEmpty(empleado.Position))
                throw new ArgumentException("Debe seleccionar un puesto laboral.");
            if (string.IsNullOrEmpty(empleado.Phone))
                throw new ArgumentException("El teléfono no puede estar vacío.");
            if (!IsUniquePhone(empleado.Phone))
                throw new ArgumentException("El teléfono ya está registrado.");
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



