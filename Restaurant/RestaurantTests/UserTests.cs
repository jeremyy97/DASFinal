using System;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestaurantTests
{/*
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void AUserIsCreated()
        {
            //Arrange
            UserLogic logic = new UserLogic();
            User lastUser;

            //Act
            string mensaje = logic.createUser("user1", "123", "Usuario", "Uno", 1, "waiter");
            lastUser = logic.SearchUserByUsername("user1");

            //Assert
            Assert.IsNotNull(lastUser);
        }

        [TestMethod]
        public void AUsernameCannotBeUsedForTwoOrMoreUsers()
        {
            //Arrange
            UserLogic logic = new UserLogic();
            User firstUser;
            User secondUser;

            //Act
            logic.createUser("user1", "123", "Mesero", "Uno", 1, "waiter");
            firstUser = logic.SearchUserById(1);

            logic.createUser("user1", "456", "Mesero", "Dos", 2, "waiter");
            secondUser = logic.SearchUserById(2);

            //Assert
            Assert.IsNotNull(firstUser);
            Assert.IsNull(secondUser);
        }
    }*/
}
