using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    public class Order : BaseTransaction  
    {
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string Observations { get; set; }

        // Relación con detalles
        public List<OrderDetail> Detalles { get; set; } = new List<OrderDetail>();

    }
}
