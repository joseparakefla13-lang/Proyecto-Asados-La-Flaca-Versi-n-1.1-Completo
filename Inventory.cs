using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo
{
    public class Inventory
    {
        public List<InventoryItem> Items { get; set; }
        public List<DishItem> Dishes { get; set; }

        public Inventory()
        {
            Items = new List<InventoryItem>();
            Dishes = new List<DishItem>();
        }

        // Agregar insumo
        public void AddProduct(string name, int quantity, int minStock)
        {
            Items.Add(new InventoryItem
            {
                Name = name,
                Quantity = quantity,
                MinStock = minStock
            });
        }

        // Agregar plato preparado
        public void AddDish(DishItem dish)
        {
            Dishes.Add(dish);
        }

        // Actualizar stock de insumos
        public void UpdateStock(string productName, int quantityUsed)
        {
            var item = Items.FirstOrDefault(i => i.Name == productName);
            if (item != null)
            {
                item.Use(quantityUsed);
            }
        }

        // Obtener insumos con bajo stock
        public List<InventoryItem> GetLowStockItems()
        {
            return Items.Where(i => i.IsLowStock()).ToList();
        }
    }

}
