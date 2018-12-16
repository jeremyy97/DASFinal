
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic;
using DBAccess;

namespace BusinessLogic
{
    public class OrderLogic
    {
        public static List<Order> Orders = new List<Order>();
        public static List<Order_Product> OrderProduct = new List<Order_Product>();
        public OrderLogic()
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            OrderProduct = DBAccessConnection.GetOrders();
            foreach (var i in OrderProduct)
            {
                Order order = new Order() { ID = i.ID, Table = i.Table, Cost = i.Cost, Paid = i.Paid, Completed = i.Completed, Product = SearchProductById(i.product) };
                Orders.Add(order);
            }
        }
        private Product SearchProductById(int id)
        {
            List<Product> Products = DBAccessConnection.GetProducts();
            foreach(var i in Products)
            {
                if(i.ID == id)
                {
                    return i;
                }
            }
            return null;
        }

        public Order_Product CreateOrder(int table, int product, decimal cost)
        {
            Order_Product order = new Order_Product() { Table = table, Product = product, Cost = cost, Completed=0, Paid =0};
            LoadOrders();
            return order;
        }

        public Order SearchOrderById(int id)
        {
            foreach (var order in Orders)
            {
                if (order.ID == id)
                {
                    return order;
                }
            }
            return null;
        }

        public Order GetOrdersToPay()
        {
            foreach (var order in Orders)
            {
                if (order.Paid == 0)
                {
                    return order;
                }
            }
            return null;
        }

        public Order GetOrdersToPay(int table)
        {
            foreach (var order in Orders)
            {
                if (order.Paid == 0 && order.Table == table)
                {
                    return order;
                }
            }
            return null;
        }

        public void PayOrder(Order order)
        {
            foreach(var i in Orders)
            {
                if (i == order)
                {
                    i.Paid = 1;
                }
            }
        }
    }
}
