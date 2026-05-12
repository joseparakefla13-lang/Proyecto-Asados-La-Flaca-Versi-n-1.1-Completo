using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<DishItem> Dishes { get; set; }

        public Order()
        {
            Dishes = new List<DishItem>();
            CreatedAt = DateTime.Now;
        }

        // Agregar un plato al pedido
        public void AddDish(DishItem dish)
        {
            Dishes.Add(dish);
        }

        // Completar pedido: descuenta platos e insumos del inventario
        public void CompleteOrder(Inventory inventory)
        {
            foreach (var dish in Dishes)
            {
                dish.ConsumeDish(inventory);
            }
        }

    }

}





