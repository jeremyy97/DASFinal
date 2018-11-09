using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public static class BillLogic
    {

        public static void AddOrder(Bill bill, Order order)
        {
            bill.Orders.Add(order);
        }

        public static decimal BillPrice(List<Order> orders)
        {
            decimal price = 0;
            if (orders.Count != 0)
            {
                foreach (var order in orders)
                {
                    price += order.Price;
                }
                return price;
            }
            else
            {
                return 0;
            }
        }

   

    }
}
