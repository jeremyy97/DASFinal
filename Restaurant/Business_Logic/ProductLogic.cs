using System;
using System.Collections.Generic;
using System.Text;
using DBAccess;
using Entities;

namespace BusinessLogic
{
    /// <summary>
    /// Getion de los productos
    /// Agregar nuevos productos
    /// Eliminar productos existentes
    /// Buscar productos por su ID
    /// </summary>
    public class ProductLogic
    {
        private static List<Product> Products = new List<Product>();

        public ProductLogic()
        {
            Products = DBAccessConnection.GetProducts();
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
                    DBAccessConnection.CreateProduct(product);
                    Products = DBAccessConnection.GetProducts();
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
                DBAccessConnection.DeleteProduct(product);
                Products = DBAccessConnection.GetProducts();
                return product;
            }
        }

        

        public List<Product> GetProducts()
        {
            return Products;
        }

    }
}
