using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo
{
    public class DishItem
    {
        public string Name { get; set; }       // Nombre del plato
        public int Quantity { get; set; }      // Cantidad disponible en inventario
        public Dictionary<string, int> Ingredients { get; set; } // Ingredientes necesarios

        public DishItem()
        {
            Ingredients = new Dictionary<string, int>();
        }

        // Agregar ingrediente a la receta
        public void AddIngredient(string ingredientName, int quantityNeeded)
        {
            Ingredients[ingredientName] = quantityNeeded;
        }

        // Consumir un plato y descontar insumos
        public void ConsumeDish(Inventory inventory)
        {
            if (Quantity > 0)
            {
                Quantity--; // Descuenta el plato preparado

                foreach (var ingredient in Ingredients)
                {
                    inventory.UpdateStock(ingredient.Key, ingredient.Value);
                }
            }
        }
    }
}