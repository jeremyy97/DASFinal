using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace BusinessLogic
{
    public class ProductLogic
    {
        private List<Product> Products = new List<Product>();

        public ProductLogic()
        {
            Products.Add(new Plate() {VeganSubstitute = "Si" ,ID = 11, Name = "Hamburguesa", Description = "Hamburguesa de la casa", Cost = 2500 });
            Products.Add(new Drink() {Size = "Pequeña", ID = 21, Name = "Coca Cola", Description = "Refresco Gaseoso", Cost = 800 });
            Products.Add(new Plate() {VeganSubstitute = "Si", ID = 12, Name = "Ensalada Cesar", Description = "Ensalada Cesar con un toque especial", Cost = 2000 });
            Products.Add(new Plate() {VeganSubstitute = "No", ID = 13, Name = "New York Steak", Description = "Nuestro corte de carne magra acompañado de verduras y ensalada", Cost = 5000 });
            Products.Add(new Drink() { Size = "Grande", ID = 22, Name = "Fresco de Cas", Description = "Bebida natural de cas", Cost = 600 });
        }

        public string AddDrink(int id, string name, string description, decimal cost,string size)
        {
            string message = "";
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || cost <= 0)
            {
                message = "Datos inválidos";
            }
            else
            {
                if (SearchByID(id) != null)
                {
                    message = "El ID del producto ya está registrado";
                }
                else
                {
                    Products.Add(new Drink() { ID = id, Name = name, Description = description, Cost = cost , Size = size});
                    message = "Producto agregado exitosamente";
                }
            }
            return message;
        }

        public string AddPlate(int id, string name, string description, decimal cost, string veganSubstitute)
        {
            string message = "";
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || cost <= 0)
            {
                message = "Datos inválidos";
            }
            else
            {
                if (SearchByID(id) != null)
                {
                    message = "El ID del producto ya está registrado";
                }
                else
                {
                    Products.Add(new Plate() { ID = id, Name = name, Description = description, Cost = cost, VeganSubstitute = veganSubstitute });
                    message = "Producto agregado exitosamente";
                }
            }
            return message;
        }

        public Product SearchByID(int id)
        {
            foreach (var product in Products)
            {
                if (product.ID == id)
                {
                    return product;
                }
            }
            return null;
        }

        public string DeleteProduct(int id)
        {
            string message = "";
            if (SearchByID(id) == null)
            {
                message = "No existe producto con este ID";
            }
            else
            {
                Product product = SearchByID(id);
                Products.Remove(product);
                message = "El producto fue eliminado exitosamente";
            }
            return message;
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> Drinks = new List<Drink>();
            foreach(Drink drink in Products)
            {
                if(drink.Size != null)
                {
                    Drinks.Add(drink);
                }
            }
            return Drinks;
        }

        public List<Plate> GetPlates()
        {
            List<Plate> Plates = new List<Plate>();
            foreach (Plate plate in Products)
            {
                if (plate.VeganSubstitute != null)
                {
                    Plates.Add(plate);
                }
            }
            return Plates;
        }

        public string GetProductsString()
        {
            StringBuilder final = new StringBuilder();
            foreach (var product in Products)
            {
                final.Append(product);
                final.Append("\n");
            }
            return final.ToString();
        }

    }
}
