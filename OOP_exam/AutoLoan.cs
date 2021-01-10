using System;
using System.Collections.Generic;
using System.Text;

namespace Loan_Program
{
    class AutoLoan : Loan
    {
        public int YearBuilt { get; set; } 
        public string Model { get; set; } 
        public string Make { get; set; }
        public string Color { get; set; }

        public AutoLoan(int loanNum, string fName, string lName, double interestRate, int loanSum, int termInYears,
             int yearBuild, string model, string make, string color)
            : base(loanNum, fName, lName, interestRate, loanSum, termInYears)
        {
            YearBuilt = yearBuild;
            Model = model;
            Make = make;
            Color = color;

        }


        public override decimal CalculateInterest()
        {
            var rate = Convert.ToDecimal(InterestRate);
            var loandDurationInMonths = Convert.ToDecimal(YearsTerm) / 12;
            decimal result = rate / loandDurationInMonths * (LoanAmount + 1000m);
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nThe car is {Model}, {YearBuilt}, {Make}, {Color} color" +
                $"\nCalculated interest is: { CalculateInterest():C2}";
        }
    }
}
