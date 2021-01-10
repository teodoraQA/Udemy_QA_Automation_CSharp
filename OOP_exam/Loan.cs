using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Program
{
    abstract class Loan
    {
        public int LoanNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double InterestRate { get; set; }
        public decimal LoanAmount { get; set; }
        public double YearsTerm { get; set; }


        public Loan(int loanNum, string fName, string lName, double interestRate, decimal loanSum, double termInYears)
        {
            LoanNumber = loanNum;
            FirstName = fName;
            LastName = lName;
            InterestRate = interestRate;
            LoanAmount = loanSum;
            YearsTerm = termInYears;
       }

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            string printInfo = $"Name of the customer {FirstName} {LastName}" +
                $"\nThe Amount of the loan: {LoanAmount:C2}" +
                $"\nThe Interest Rate is {InterestRate*100:F2}%";
            return printInfo;
        }
    }
}
