using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    public class OrderDetail : BaseTransaction
    {

            public string ProductName { get; set; }
            public int Quantity { get; set; }   // en C# usamos Quantity, pero se mapea a Cuantity en SQL
            public decimal UnitPrice { get; set; }
            public decimal SubTotal { get; private set; }
            public string Customer { get; set; }
            public string OrderEmployee { get; set; }

            public void CalcularSubTotal()
            {
                SubTotal = Quantity * UnitPrice;
            }
        


        public bool EsValido()
            {
                return Quantity > 0 && UnitPrice > 0 && !string.IsNullOrEmpty(ProductName);
            }
        


    }

}
