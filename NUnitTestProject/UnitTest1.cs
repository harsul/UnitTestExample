using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTextExample;

namespace NUnitTestProject
{
    public class Tests
    {
        [TestClass]
        public class StockManagementTests
        {
            [TestMethod]
            public void TestMethod1()
            {
                // Arrange
                double beginningQuantity = 11.99;
                double debitAmount = 4.55;
                double expected = 7.44;

                StockManagement account = new StockManagement("304L","Stailnes Steel", beginningQuantity);

                // Act
                account.Debit(debitAmount);

                // Assert
                double actual = account.Balance;
                Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
            }
        }
    }
}