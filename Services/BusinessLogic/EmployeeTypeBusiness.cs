using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic
{
    internal class EmployeeTypeBusiness
    {
        /// <summary>
        /// Obtiene todos los tipos de empleado distintos que existen en la tabla Employee.
        /// </summary>
        public DataTable GetPosition()
        {
            string sql = @"SELECT DISTINCT Position FROM Employee WHERE Available = 1";

            using (var select = new SelectQuery())
            {
                return select.ExecuteSelect(sql);
            }
        }
    }
}
