using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo
{
    public class OrderItem
    {
      
            // Nombre del producto
            public string Name { get; set; }

            // Cantidad de unidades del producto
            public int Quantity { get; set; }

            // Precio unitario del producto
            public decimal UnitPrice { get; set; }

            // Método para calcular el subtotal (cantidad × precio unitario)
            public decimal GetSubtotal()
            {
                return Quantity * UnitPrice;
            }

            // Método para actualizar la cantidad del producto con validación
            public void UpdateQuantity(int newQuantity)
            {
                if (newQuantity > 0)
                    Quantity = newQuantity;
            }

            // Método para actualizar el precio unitario con validación
            public void UpdatePrice(decimal newPrice)
            {
                if (newPrice >= 0)
                    UnitPrice = newPrice;
            }

            // Método para mostrar la información del producto en formato legible
            public string GetInfo()
            {
                return $"{Name} - Cantidad: {Quantity}, Precio: {UnitPrice:C}, Subtotal: {GetSubtotal():C}";
            }
    }
}


