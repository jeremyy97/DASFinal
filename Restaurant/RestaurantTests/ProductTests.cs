using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using Entities;

namespace RestaurantTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void AProductIsCreated()
        {
            ProductLogic logic = new ProductLogic();
            logic.AddPlate(1, "Hamburguesa", "Rica hamburguesa doble queso", 2500, "Si");
            Product lastProduct = logic.SearchByID(1);
            Assert.IsNotNull(lastProduct);
        }

        [TestMethod]
        public void EachProductHasAUniqueID()
        {
            ProductLogic logic = new ProductLogic();
            logic.AddPlate(1, "Hamburguesa", "Rica hamburguesa doble queso", 2500, "Si");
            Product firstProduct = logic.SearchByID(1);

            logic.AddDrink(1, "Coca Cola", "Coca Cola de 500ml", 800, "Pequeña");
            Product secondProduct = logic.SearchByID(1);

            Assert.AreSame(firstProduct.Name, "Hamburguesa");
            Assert.AreNotSame(secondProduct.Name, "Coca Cola");
        }

        [TestMethod]
        public void DeleteAnExistingProduct()
        {
            ProductLogic logic = new ProductLogic();
            logic.AddPlate(1, "Hamburguesa", "Rica hamburguesa doble queso", 2500, "Si");
            Product lastProduct = logic.SearchByID(1);

            Assert.IsNotNull(lastProduct);
            logic.DeleteProduct(1);

            lastProduct = logic.SearchByID(1);
            Assert.IsNull(lastProduct);
        }
    }
}
