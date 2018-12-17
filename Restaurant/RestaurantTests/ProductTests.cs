using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using BusinessLogic;

namespace RestaurantTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void AProductIsCreated()
        {
            ProductLogic logic = new ProductLogic();
            logic.AddProduct(3, "Hamburguesa", "Rica hamburguesa doble queso", 2500);
            Product lastProduct = logic.SearchByID(3);
            Assert.IsNotNull(lastProduct);
        }

        [TestMethod]
        public void EachProductHasAUniqueID()
        {
            ProductLogic logic = new ProductLogic();
            
            Product firstProduct = logic.AddProduct(4, "Hamburguesa", "Rica hamburguesa doble queso", 2500);
            Product secondProduct = logic.AddProduct(4, "Coca Cola", "Coca Cola de 500ml", 800);

            Assert.IsNotNull(firstProduct);
            Assert.IsNull(secondProduct);
        }

        [TestMethod]
        public void DeleteAnExistingProduct()
        {
            ProductLogic logic = new ProductLogic();
            logic.AddProduct(5, "Hamburguesa", "Rica hamburguesa doble queso", 2500);
            Product lastProduct = logic.SearchByID(5);

            Assert.IsNotNull(lastProduct);
            logic.DeleteProduct(5);

            lastProduct = logic.SearchByID(5);
            Assert.IsNull(lastProduct);
        }
    }
}
