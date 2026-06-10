using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services;
using System;
using System.Data;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    internal class Customer
    {  
        public required string CustomerCode { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string TypeOfCustomer { get; set; }
        public bool IsEnable { get; set; }
        public DateTime RegisterDate { get; set; }

        public Customer()
        {
            CustomerCode = string.Empty;
            Name = string.Empty;
            Phone = string.Empty;
            TypeOfCustomer = string.Empty;
            IsEnable = true;
            RegisterDate = DateTime.Now;
        }

        public bool ValidateCurrentDate()
        {
            return RegisterDate.Date <= DateTime.Today;
        }

        public Customer(string customerCode)
        {
            LoadCustomerById(customerCode);
        }

        public Customer(string customerCode, string name, string phone, string typeOfCustomer, bool isEnable, DateTime registerDate)
        {
            CustomerCode = customerCode;
            Name = name;
            Phone = phone;
            TypeOfCustomer = typeOfCustomer;
            IsEnable = isEnable;
            RegisterDate = registerDate;
        }
        

    
        public bool IsUniqueCustomerCode(string customerCode)
        {
            string sql = @"SELECT CASE
                            WHEN EXISTS(
                                 SELECT 1
                                 FROM Customer 
                                 WHERE CustomerCode = @CustomerCode)
                                 THEN 1 ELSE 0 END";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parametros = {
            new SqlParameter("@CustomerCode", SqlDbType.VarChar, 16) { Value = customerCode }
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

                string sql = @"INSERT INTO Customer (CustomerCode, Name, Phone, TypeOfCustomer, Available, RegisterDate)
                           VALUES (@CustomerCode, @Name, @Phone, @TypeOfCustomer, @Available, @RegisterDate)";

                SqlParameter[] parameters =
                {
                new SqlParameter("@CustomerCode", SqlDbType.VarChar, 16) { Value = this.CustomerCode },
                new SqlParameter("@Name", SqlDbType.VarChar, 108) { Value = this.Name },
                new SqlParameter("@Phone", SqlDbType.VarChar, 16) { Value = this.Phone },
                new SqlParameter("@TypeOfCustomer", SqlDbType.VarChar, 16) { Value = this.TypeOfCustomer },
                new SqlParameter("@Available", SqlDbType.Bit) { Value = this.IsEnable },
                new SqlParameter("@RegisterDate", SqlDbType.DateTime) { Value = this.RegisterDate }
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
            string sql = @"SELECT CustomerCode, Name, Phone, TypeOfCustomer, Available, RegisterDate
                       FROM Customer";

            using SelectQuery select = new SelectQuery();
            return select.ExecuteSelect(sql, null);
        }

        private void LoadCustomerById(string customerCode)
        {
            string sql = @"SELECT CustomerCode, Name, Phone, TypeOfCustomer, Available, RegisterDate
                       FROM Customer WHERE CustomerCode = @CustomerCode";

            using SelectQuery select = new SelectQuery();
            SqlParameter[] parameters = {
            new SqlParameter("@CustomerCode", SqlDbType.VarChar, 16) { Value = customerCode }
        };

            DataTable dt = select.ExecuteSelect(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                CustomerCode = row["CustomerCode"].ToString() ?? string.Empty;
                Name = row["Name"].ToString() ?? string.Empty;
                Phone = row["Phone"].ToString() ?? string.Empty;
                TypeOfCustomer = row["TypeOfCustomer"].ToString() ?? string.Empty;
                IsEnable = Convert.ToBoolean(row["Available"]);
                RegisterDate = Convert.ToDateTime(row["RegisterDate"]);
            }
        }
    
    } 
}



