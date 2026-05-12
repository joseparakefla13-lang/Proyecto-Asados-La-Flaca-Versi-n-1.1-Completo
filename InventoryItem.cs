using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo
{
    public class InventoryItem
    {
        public string Name { get; set; }    // Nombre del insumo
        public int Quantity { get; set; }   // Cantidad disponible
        public int MinStock { get; set; }   // Stock mínimo

        public void Use(int amount)
        {
            if (amount > 0 && amount <= Quantity)
                Quantity -= amount;
        }

        public bool IsLowStock()
        {
            return Quantity <= MinStock;
        }
    }
}


