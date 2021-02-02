using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            double beginningQuantity = 540;
            double added = 120;
            double expected = 660;
            StockManagement stockManagement = new StockManagement("304L", "SS", beginningQuantity);

            // Act
            stockManagement.Receipt(added);

            // Assert
            double actual = stockManagement.StockBalance;
            Assert.AreEqual(expected, actual, 680, "Stock not added correctly");
        }
    }
}
