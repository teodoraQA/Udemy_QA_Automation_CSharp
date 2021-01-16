using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Application
{
    class MultiUnit : Housing, IUnits
    {
        //Include data characteristics such as complex name, number of units, and rent amount per unit

        public string ComplexName { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal RentPerUnit { get; set; }

        public MultiUnit(string address, string constType, int yrBuild, string complexName, int numOfUnits, decimal rentPerUnit)
            : base(address, constType, yrBuild)
        {
            ComplexName = complexName;
            NumberOfUnits = numOfUnits;
            RentPerUnit = rentPerUnit;
        }

        /* Contains an override method ProjectedRentalAmt(), returns a decimal. 
        Take the rent amount per unit multiplied by the number of units, multiplied by 12 months.*/

        public override decimal ProjectedRentalAmt()
        {
            return RentPerUnit * NumberOfUnits * 12;
        }

        // Contains the method GetNumUnits, returns int – required by the Interface

        public int GetNumberOfUnits()
        {
            return NumberOfUnits;
        }

        // Contains an override ToString method that prints all of the relevant class information as a string.

        public override string ToString()
        {
            string complexInfo = base.ToString() + $"\nComplex name: {ComplexName}" +
                $"\nNumber of units: {NumberOfUnits}\nRent per unit: {RentPerUnit:C2}" +
                $"\nProjected Annual Rent From This Address: {ProjectedRentalAmt():C2}";
            return complexInfo;
        }

    }
}
