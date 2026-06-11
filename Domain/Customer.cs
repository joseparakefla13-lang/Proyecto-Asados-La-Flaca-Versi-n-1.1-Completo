using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services;
using System;
using System.Data;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{  
    internal class Customer : Person
    {
        public int CustomerId { get; set; }
        public string TypeCustomer { get; set; }

        // Constructor por defecto
        public Customer() : base(string.Empty, string.Empty, string.Empty, true)
        {
            TypeCustomer = string.Empty;
            RegistDate = DateTime.Today; // siempre hoy
        }

        // Constructor para cargar desde BD
        public Customer(string clustomerCode) : base(clustomerCode, string.Empty, string.Empty, true)
        {
            LoadCustomerById(clustomerCode);
        }

        // Constructor completo
        public Customer(int customerId, string code, string names, string phone, bool available, string typeCustomer)
            : base(code, names, phone, available)
        {
            CustomerId = customerId;
            TypeCustomer = typeCustomer;
            RegistDate = DateTime.Today; // fuerza fecha actual
        }

        /* -------------------------------------------------------------------------- */
        /*                               Métodos BD                                   */
        /* -------------------------------------------------------------------------- */

        public bool IsUniqueCustomerCode(string clustomerCode)
        {
            string sql = @"SELECT COUNT(*) 
                   FROM Customer 
                   WHERE ClustomerCode = @ClustomerCode";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parametros = {
        new SqlParameter("@ClustomerCode", SqlDbType.VarChar, 16) { Value = clustomerCode }
    };

            int count = Convert.ToInt32(select.ExecuteScalar(sql, parametros));
            return count == 0; // true si no existe
        }

        public int InsertCustomer()
        {
            int rows = 0;
            try
            {
                using InsertCommand insert = new InsertCommand();

                string sql = @"INSERT INTO Customer (ClustomerCode, Names, Phone, TypeCustomer, Available, RegistDate)
                       VALUES (@ClustomerCode, @Names, @Phone, @TypeCustomer, @Available, @RegistDate)";

                SqlParameter[] parameters =
                {
            new SqlParameter("@ClustomerCode", SqlDbType.VarChar, 16) { Value = this.ClustomerCode },
            new SqlParameter("@Names", SqlDbType.VarChar, 108) { Value = this.Names },
            new SqlParameter("@Phone", SqlDbType.VarChar, 16) { Value = this.Phone },
            new SqlParameter("@TypeCustomer", SqlDbType.VarChar, 16) { Value = this.TypeCustomer },
            new SqlParameter("@Available", SqlDbType.Bit) { Value = this.Available },
            new SqlParameter("@RegistDate", SqlDbType.DateTime) { Value = this.RegistDate }
                };

                rows = insert.ExecuteInsert(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente.", ex);
            }

            return rows;
        }

        public DataTable GetAllCustomers()
        {
            string sql = @"SELECT ClustomerCode, Names, Phone, TypeCustomer, Available, RegistDate
                       FROM Customer";

            using SelectQuery select = new SelectQuery();
            return select.ExecuteSelect(sql, null);
        }

        private void LoadCustomerById(string clustomerCode)
        {
            string sql = @"SELECT ClustomerCode, Names, Phone, TypeCustomer, Available, RegistDate
                       FROM Customer WHERE ClustomerCode = @ClustomerCode";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parameters = {
            new SqlParameter("@ClustomerCode", SqlDbType.VarChar, 16) { Value = clustomerCode }
        };

            DataTable dt = select.ExecuteSelect(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                ClustomerCode = row["ClustomerCode"].ToString() ?? string.Empty; // heredado de Person
                Names = row["Names"].ToString() ?? string.Empty;
                Phone = row["Phone"].ToString() ?? string.Empty;
                TypeCustomer = row["TypeCustomer"].ToString() ?? string.Empty;
                Available = Convert.ToBoolean(row["Available"]);
                RegistDate = Convert.ToDateTime(row["RegistDate"]);
            }
        }
    }

}





