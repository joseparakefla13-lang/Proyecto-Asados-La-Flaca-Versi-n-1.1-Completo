using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    internal class Employee : Person
    {

        // Propiedades específicas de Employee
        public String SurNames { get; set; }
        public string EmployeeCode { get; set; }
        public string Position { get; set; }

        // Constructor vacío
        public Employee() { }

        // Constructor que carga directamente desde BD
        public Employee(string employeeCode)
        {
            LoadEmployeeById(employeeCode);
        }

        // Método para cargar datos del empleado desde BD
        private void LoadEmployeeById(string employeeCode)
        {
            string sql = @"SELECT EmployeeCode, Names, Phone, Position, Available
                       FROM Employee WHERE EmployeeCode = @EmployeeCode";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parameters = {
            new SqlParameter("@EmployeeCode", SqlDbType.VarChar, 16) { Value = employeeCode }
        };

            DataTable dt = select.ExecuteSelect(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                EmployeeCode = row["EmployeeCode"].ToString() ?? string.Empty;
                Names = row["Names"].ToString() ?? string.Empty;
                Phone = row["Phone"].ToString() ?? string.Empty;
                SurNames = row["SurNames"].ToString() ?? string.Empty;
                Position = row["Position"].ToString() ?? string.Empty;
                Available = Convert.ToBoolean(row["Available"]);
            }
        }
    }

}

