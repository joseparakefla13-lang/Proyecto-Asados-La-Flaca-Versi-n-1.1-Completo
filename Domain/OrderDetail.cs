using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    public class OrderDetail : BaseTransaction
    {

        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }

        public void CalcularSubTotal()
        {
            SubTotal = Quantity * UnitPrice;
        }

        public bool EsValido()
        {
            return Quantity > 0 && UnitPrice > 0 && !string.IsNullOrWhiteSpace(ProductName);
        }


    }
}
