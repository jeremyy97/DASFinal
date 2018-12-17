
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
            Orders.Clear();
            OrderProduct = DBAccessConnection.GetOrders();
            foreach (var i in OrderProduct)
            {
                Order order = new Order() { ID = i.ID, Table = i.Table_id, Cost = i.Cost, Paid = i.Paid, Completed = i.Completed, Product = SearchProductById(i.Product_id) };
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
            Order_Product order = new Order_Product() { Table_id = table, Product_id = product, Cost = cost, Completed=0, Paid =0};
            DBAccessConnection.CreateOrder(order);
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

        public List<Order> GetOrdersToPay()
        {
            List<Order> orders = new List<Order>();
            foreach (var order in Orders)
            {
                if (order.Paid == 0)
                {
                    orders.Add(order);
                }
            }
            return orders;
        }

        public List<Order> GetOrdersToPay(int table)
         {
            List<Order> orders = new List<Order>();
            foreach (var order in Orders)
            {
                if (order.Paid == 0 && order.Table == table)
                {
                    orders.Add(order);
                }
            }
            return orders;

        }

        public void PayOrder(Order order)
        {
            foreach(var i in Orders)
            {
                if (i == order)
                {
                    DBAccessConnection.PayOrder(i.ID);
                }
            }
            LoadOrders();
        }
    }
}
