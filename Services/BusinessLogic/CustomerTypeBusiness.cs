using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic
{
    internal class CustomerTypeBusiness
    {
        /// <summary>
        /// Obtiene todos los tipos de cliente distintos que existen en la tabla Customer.
        /// </summary>
        public DataTable GetCustomerTypes()
        {
            string sql = @"SELECT DISTINCT TypeCustomer 
                       FROM Customer 
                       WHERE Available = 1";

            using SelectQuery select = new SelectQuery();
            return select.ExecuteSelect(sql);
        }

    }
}
