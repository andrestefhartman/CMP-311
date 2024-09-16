using Microsoft.VisualStudio.TestTools.UnitTesting;
using PricingEngineApp;

namespace PricingEngineTests
{
    [TestClass]
    public class PricingValueTests
    {
        [TestMethod]
        public void CalculateUnitPrice_BelowMinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 0.50m);
            // assert
            Assert.AreEqual(unitPrice, 0.50m);

        }

        [TestMethod]
        public void CalculateUnitPrice_MinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 1.00m);
            // assert
            Assert.AreEqual(unitPrice, 1.000m);
        }

        [TestMethod]
        public void CalculateUnitPrice_BelowMinQty()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(5, 2.00m);
            // assert
            Assert.AreEqual(unitPrice, 2.000m);
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyLower()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 2.00m);
            // assert
            Assert.AreEqual(unitPrice, 2.000m);
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyUpper()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(20, 2.00m);
            // assert
            Assert.AreEqual(unitPrice, 2.000m * 9 / 10);
        }

        [TestMethod]
        public void CalculateUnitPrice_QtyGT20()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(25, 2.00m);
            // assert
            Assert.AreEqual(unitPrice, 2.000m * 8 / 10);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 0.50m);
            // assert
            Assert.AreEqual(unitPrice, 0.500m);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinTotal()
        {
            // arrange
            PricingEngine engine = new PricingEngine(true);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(25, 2.00m);
            // assert
            Assert.AreEqual(unitPrice, 2.000m * 8 / 10);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold
            PricingEngine engine = new PricingEngine(true);
            // arrange
            decimal unitPrice = engine.CalculateUnitPrice(10, 2.00m);
            // act

            // assert
            Assert.AreEqual(unitPrice, 2.00m);
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold
            PricingEngine engine = new PricingEngine(true);
            // arrange
            decimal unitPrice = engine.CalculateUnitPrice(10, 120.00m);
            // act

            // assert
            Assert.AreEqual(unitPrice, 120.000m * 9 / 10);
        }
    }
}