using System.ComponentModel;
using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PriceTestLatte()
        {
            //Arrange
            var latte = new Latte();
            //Act
            int price = latte.Price();
            //Assert
            Assert.AreEqual(40,price);
        }

        [TestMethod]
        public void PriceTestBlackCoffee()
        {
            //Arrange
            var blackcoffee = new BlackCoffee();
            //Act 
            int price = blackcoffee.Price();
            //Assert
            Assert.AreEqual(20,price);
        }

        [TestMethod]
        public void PriceTestCortado()
        {
            //Arrange
            var cortado = new Cortado();
            //Act 
            int price = cortado.Price();
            //Assert
            Assert.AreEqual(25, price);
        }

        [TestMethod]
        public void StrengthTestLatte()
        {
            //Arrange
            var latte = new Latte();
            //Act
            string strength = latte.Strength();
            //Assert
            Assert.AreSame("Weak", strength);
        }

        [TestMethod]
        public void StrengthTestBlackCoffee()
        {
            //Arrange
            var blackCoffee = new BlackCoffee();
            //Act
            string strength = blackCoffee.Strength();
            //Assert
            Assert.AreSame("Strong", strength);
        }

        [TestMethod]
        public void StrengthTestCortado()
        {
            //Arrange
            var cortado = new Cortado();
            //Act
            string strength = cortado.Strength();
            //Assert
            Assert.AreSame("Medium", strength);
        }
    }
}
