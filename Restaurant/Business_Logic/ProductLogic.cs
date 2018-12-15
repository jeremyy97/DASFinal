using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace BusinessLogic
{
    public class ProductLogic
    {
        private static List<Product> Products = new List<Product>();

        public ProductLogic()
        {
            Products.Add(new Product() {ID = 11, Name = "Hamburguesa", Description = "Hamburguesa de la casa", Cost = 2500 });
            Products.Add(new Product() {ID = 21, Name = "Coca Cola", Description = "Refresco Gaseoso", Cost = 800 });
            Products.Add(new Product() {ID = 12, Name = "Ensalada Cesar", Description = "Ensalada Cesar con un toque especial", Cost = 2000 });
            Products.Add(new Product() {ID = 13, Name = "New York Steak", Description = "Nuestro corte de carne magra acompañado de verduras y ensalada", Cost = 5000 });
            Products.Add(new Product() {ID = 22, Name = "Fresco de Cas", Description = "Bebida natural de cas", Cost = 600 });
        }


        public Product AddProduct(int id, string name, string description, decimal cost)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || cost < 0)
            {
                return null;
            }
            else
            {
                if (SearchByID(id) != null)
                {
                    return null;
                }
                else
                {
                    Product product = new Product() { ID = id, Name = name, Description = description, Cost = cost };
                    Products.Add(product);
                    return product;
                }
            }
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

        public Product DeleteProduct(int id)
        {
            if (SearchByID(id) == null)
            {
                return null;
            }
            else
            {
                Product product = SearchByID(id);
                Products.Remove(product);
                return product;
            }
        }

        

        public List<Product> GetProducts()
        {
            return Products;
        }

    }
}
