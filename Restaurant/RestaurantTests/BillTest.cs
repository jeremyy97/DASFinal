using System;
using BusinessLogic;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestaurantTests
{
    [TestClass]
    public class BillTest
    {
        [TestMethod]
        public void ABillIsCreated()
        {
            BillLogic logic = new BillLogic(1);
            Bill bill = logic.CreateBill(1,"Jeremy Cerdas");
            Assert.IsNotNull(bill);
        }

        [TestMethod]
        public void AddAnOrderToAnExistingBill()
        {
            BillLogic logic = new BillLogic(1);
            Bill bill = logic.CreateBill(2, "Jeremy Cerdas");
            Order OrderAdded = logic.AddOrderToABill(1);
            Assert.IsNotNull(OrderAdded);
        }
    }
}
