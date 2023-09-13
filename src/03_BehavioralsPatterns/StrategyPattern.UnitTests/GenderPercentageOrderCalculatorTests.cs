using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StrategyPattern.UnitTests
{
    [TestClass]
    public class GenderPercentageOrderCalculatorTests
    {
        private OrderCalculator calculator;

        [TestInitialize]
        public void Init()
        {
            ICanDiscountStrategy canDiscountStategy = new GenderCanDiscountStrategy(Gender.Female);
            ICalculateDiscountStrategy calculateDiscount = new PercentageDiscountStrategy(0.1m);

            calculator = new OrderCalculator(canDiscountStategy, calculateDiscount);
        }

        [TestMethod]
        public void CalculateDiscount_Female_ShouldDiscount()
        {
            // Arrange
            Order order = new Order(DateTime.MinValue, new Customer { Gender = Gender.Female }, 100);

            // Act
            decimal discount = calculator.CalculateDiscount(order);

            // Assert
            Assert.AreEqual(10, discount);

        }

        [TestMethod]
        public void CalculateDiscount_Male_ShouldNotDiscount()
        {
            // Arrange
            Order order = new Order(DateTime.MinValue, new Customer { Gender = Gender.Male }, 100);

            // Act
            decimal discount = calculator.CalculateDiscount(order);

            // Assert
            Assert.AreEqual(0, discount);

        }

    }
}
