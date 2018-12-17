using System;
using System.Collections.Generic;
using BusinessLogic;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestaurantTests
{
    [TestClass]
    public class OrdersTest
    {
        [TestMethod] 
        public void AnOrderIsCreated()
        {
            OrderLogic logic = new OrderLogic();
            logic.CreateOrder(1, 1, 2500);
            Order lastOrder = logic.SearchOrderById(1);
            Assert.IsNotNull(lastOrder);
        }

        [TestMethod]
        public void OnlyNotPaidOrdersCanBeListedToBePaid()
        {
            OrderLogic logic = new OrderLogic();
            logic.CreateOrder(1, 1, 2500);
            List<Order> orders = logic.GetOrdersToPay(1);

            Assert.IsNotNull(orders);
            foreach (var i in orders)
            {
                logic.PayOrder(i);
            }
            orders.Clear();
            orders = logic.GetOrdersToPay(1);
            Assert.AreEqual(orders.Count,0);
        }
    }
}
