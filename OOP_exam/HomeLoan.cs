using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Program
{
    class HomeLoan : Loan
    {
        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public int SquareFootage { get; set; }

        public HomeLoan(int loanNum, string fName, string lName, double interestRate, int loanSum, int termInYears, 
            string adress, int yearBuild, int sqFootage)
            : base(loanNum, fName, lName, interestRate, loanSum, termInYears)
        {
            Address = adress;
            YearBuilt = yearBuild;
            SquareFootage = sqFootage;

        }
        //HomeLoan should use the formula: (interest rate / number of payments (in months)
        //X loan principal (the total amount they are borrowing + an admin fee of $5000)
        public override decimal CalculateInterest()
        {
            var rate = Convert.ToDecimal(InterestRate);
            var loandDurationInMonths= Convert.ToDecimal(YearsTerm) / 12;
            decimal result = rate / loandDurationInMonths * (LoanAmount + 5000m);
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nThe adress of the home is: {Address}" +
                $"\nThe year it is build is {YearBuilt}\n The size is {SquareFootage}" +
                $"\nCalculated interest is: {CalculateInterest():C2}";
        }

    }
}
