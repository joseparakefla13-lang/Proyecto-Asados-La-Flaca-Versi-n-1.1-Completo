using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services;
using System;
using System.Data;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    internal class Customer
    {
        #region Properties
        public required string CustomerCode { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string TypeOfCustomer { get; set; }
        public bool Available { get; set; }
        public DateTime RegistDate { get; set; }
        #endregion

        #region Constructors
        public Customer()
        {
            CustomerCode = string.Empty;
            Name = string.Empty;
            Phone = string.Empty;
            TypeOfCustomer = string.Empty;
            Available = true;
            RegistDate = DateTime.Now;
        }
        public bool ValidateCurrentDate()
        {
            // Validar que la fecha de registro no sea futura
            if (RegistDate.Date <= DateTime.Today)
            {
                return true; // La fecha de registro es válida (hoy o antes)
            }
            return false; // La fecha de registro es inválida (mañana o más adelante)
        }

        // Constructor para cargar desde BD
        public Customer(string customerCode)
        {
            LoadCustomerById(customerCode);
        }

        public Customer(string customerCode, string name, string phone, string typeOfCustomer, bool available, DateTime registDate)
        {
            CustomerCode = customerCode;
            Name = name;
            Phone = phone;
            TypeOfCustomer = typeOfCustomer;
            Available = available;
            RegistDate = registDate;
        }
        #endregion

        #region Methods
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

            return select.IsDuplicate(sql, parametros);
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
                    new SqlParameter("@Available", SqlDbType.Bit) { Value = this.Available },
                    new SqlParameter("@RegisterDate", SqlDbType.DateTime) { Value = this.RegistDate }
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
            return select.ExecuteSelect(sql, null); // null porque no hay parámetros
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
                Available = Convert.ToBoolean(row["Available"]);
                RegistDate = Convert.ToDateTime(row["RegistDate"]);
            }
        }
        #endregion
    }
}

