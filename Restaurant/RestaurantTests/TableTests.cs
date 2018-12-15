using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;

namespace RestaurantTests
{
    [TestClass]
    public class TableTests
    {
        /*
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
            logic.AddTable(1, 4);
            logic.ChangeStatus(1);

            List<Table> tables = logic.GetAvailableTables();

            Assert.AreNotSame(tables.Count,1);
        }
        */
    }
}
