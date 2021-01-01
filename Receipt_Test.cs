using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Retail_Store_Exam
{
    [TestClass]
    public class Receipt_Test
    {
        //assume each receipt is for a single ticket item and contains a single item number.
        //Each of the 5 validation items should be tested with individual test methods. 
        //Create a test method that shows a valid input and an invalid input. (You’ll have 10 test methods)
        [TestMethod]
        [TestCategory("Positive")]
        public void TestReceiptNum()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 1);
            Console.WriteLine(newPurchase.ReceiptNumber);
            Assert.AreEqual(1, newPurchase.ReceiptNumber);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void TestCustomerNumber()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 1);
            Console.WriteLine(newPurchase.CustomerNumber);
            Assert.AreEqual(100, newPurchase.CustomerNumber);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void TestItemNumber()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 1);
            Console.WriteLine(newPurchase.ItemNumber);
            Assert.AreEqual(123, newPurchase.ItemNumber);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void TestUnitPrice()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 1);
            Console.WriteLine(newPurchase.UnitPrice);
            Assert.AreEqual(5.00m, newPurchase.UnitPrice);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void TestQtyPurchased()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 2);
            Console.WriteLine(newPurchase);
            Assert.AreEqual(2, newPurchase.QtyPurchased);
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void TestTotalSum()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 2);
            Console.WriteLine(newPurchase);
            Assert.AreEqual(10.00m, newPurchase.CalculateTotalCost());
        }


        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestReceiptNumFail()
        {
            Receipt newPurchase = new Receipt(-1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 2);
            if (newPurchase.ReceiptNumber == 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestCustomerNumberFail()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", -2, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 1);
            Console.WriteLine(newPurchase.CustomerNumber);
            if (newPurchase.CustomerNumber == 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestItemNumberFail()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 9999, "chocolate", 5.00m, 1);
            Console.WriteLine(newPurchase.ItemNumber);
            if (newPurchase.ItemNumber == 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestUnitPriceFail()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 9999m, 1);
            Console.WriteLine(newPurchase.UnitPrice);
            if (newPurchase.UnitPrice == 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestQtyPurchasedeFail()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, -1);
            Console.WriteLine(newPurchase.QtyPurchased);
            if (newPurchase.QtyPurchased == 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestTotalSumFail()
        {
            Receipt newPurchase = new Receipt(1, "1.01.2021", 100, "Teodora Georgieva", "Sofia", "+359894123456", 123, "chocolate", 5.00m, 2);
            Console.WriteLine(newPurchase);
            Assert.AreEqual(5.00m, newPurchase.CalculateTotalCost());
        }
    }
}
