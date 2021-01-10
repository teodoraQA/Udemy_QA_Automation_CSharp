using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loan_Program

{
    [TestClass]
    public class Loan_Tests
    {
        [TestMethod]
        public void AutoLoan_Test()
        {
             AutoLoan newCarLoan = new AutoLoan (1, "John", "Peterson", 0.075, 12000, 4, 2015, "Taurus",
                "Ford", "Blue");
            Assert.AreEqual(2925, newCarLoan.CalculateInterest());
            System.Console.WriteLine(newCarLoan);

        }

        [TestMethod]
        public void HomeLoan_Test()
        {
            HomeLoan newHomeLoan = new HomeLoan(1, "John", "Peterson", 0.035, 210000, 30, "123 Street, Somewhere",2015, 90 );
            Assert.AreEqual(3010, newHomeLoan.CalculateInterest());
            System.Console.WriteLine(newHomeLoan);

        }

    }
}
