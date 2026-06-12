using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    public class Product: BaseTransaction
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
