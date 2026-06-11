using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services;
using System;
using System.Data;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    internal class Customer
    {  
        public  string ClustomerCode { get; set; }
        public  string Names { get; set; }
        public  string Phone { get; set; }
        public  string TypeCustomer { get; set; }
        public bool  Available { get; set; }
        public DateTime RegistDate { get; set; }

        public Customer()
        {
            ClustomerCode = string.Empty;
            Names = string.Empty;
            Phone = string.Empty;
            TypeCustomer = string.Empty;
            Available = true;
            RegistDate = DateTime.Now;
        }

        public bool ValidateCurrentDate()
        {
            return RegistDate.Date <= DateTime.Today;
        }

        public Customer (string customerCode)
        {
            LoadCustomerById(customerCode);
        }

        public Customer(string clustomerCode, string name, string phone, string typeCustomer, bool available, DateTime registDate)
        {
            ClustomerCode = clustomerCode;
            Names = name;
            Phone = phone;
            TypeCustomer = typeCustomer;
            Available = available;
            RegistDate = registDate ;
        }
        

    
        public bool IsUniqueCustomerCode(string clustomerCode)
        {
            string sql = @"SELECT CASE
                            WHEN EXISTS(
                                 SELECT 1
                                 FROM Customer 
                                 WHERE ClustomerCode = @ClustomerCode)
                                 THEN 1 ELSE 0 END";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parametros = {
            new SqlParameter("@ClustomerCode", SqlDbType.VarChar, 16) { Value = clustomerCode }
        };

            // Devuelve true si NO existe (es único)
            return !select.IsDuplicate(sql, parametros);
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

        private void LoadCustomerById(string customerCode)
        {
            string sql = @"SELECT ClustomerCode, Names, Phone, TypeCustomer, Available, RegistDate
                       FROM Customer WHERE ClustomerCode = @ClustomerCode";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parameters = {
            new SqlParameter("@ClustomerCode", SqlDbType.VarChar, 16) { Value = customerCode }
        };

            DataTable dt = select.ExecuteSelect(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                ClustomerCode = row["ClustomerCode"].ToString() ?? string.Empty;
                Names = row["Names"].ToString() ?? string.Empty;
                Phone = row["Phone"].ToString() ?? string.Empty;
                TypeCustomer = row["TypeCustomer"].ToString() ?? string.Empty;
                Available = Convert.ToBoolean(row["Available"]);
                RegistDate = Convert.ToDateTime(row["RegistDate"]);
            }
        }
    
    } 
}




