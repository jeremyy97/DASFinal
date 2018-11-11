﻿using DataAccess;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public static class OrderLogic
    {

        public static int OrderSize(List<Product> products)
        {
            return products.Count;
        }

        public static decimal OrderCost(List<Product> products)
        {
            if (products.Count != 0)
            {
                decimal price = 0;
                foreach (var product in products)
                {
                    price += product.Cost;
                }
                return price;
            }
            else
            {
                return 0;
            }
        }

        public static string PrintProducts(List<Product> products)
        {
            if (products.Count != 0)
            {
                string print = "";
                foreach (var product in products)
                {
                    print += product + "\n";
                }
                return print;
            }
            else
            {
                return "No hay productos en la orden";
            }
        }

        public static string PrintOrder(Order order)
        {
            return "Orden #" + order.ID + "\nProductos: \n" + PrintProducts(order.Products) + "\nMonto Orden: " + OrderCost(order.Products);
        }

        public static void CloseOrder(Order order)
        {
            order.Size = OrderSize(order.Products);
            order.Cost = OrderCost(order.Products);
            order.Paid = false;
        }
    }
}
