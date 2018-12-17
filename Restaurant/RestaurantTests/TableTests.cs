using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using BusinessLogic;

namespace RestaurantTests
{
    [TestClass]
    public class TableTests
    {
       
        [TestMethod]
        public void EachTableHasAUniqueID()
        {
            TableLogic logic = new TableLogic();
            logic.AddTable(1,4);
            Table firstTable = logic.SearchByPeople(4);

            logic.AddTable(1,8);
            Table secondTable = logic.SearchByPeople(8);

            Assert.IsNotNull(firstTable);
            Assert.IsNull(secondTable);
        }

        [TestMethod]
        public void OnlyAvailableTablesCanBeUsed()
        {
            TableLogic logic = new TableLogic();
            logic.AddTable(2, 6);
            Table firstPick = logic.PickTable(2);
            Table secondPick = logic.PickTable(2);

            Assert.IsNotNull(firstPick,"UNO");
            Assert.IsNull(secondPick);
        }
        
    }
}
