using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Application
{
    class Housing
    {
        //Include data characteristics such as address, type of construction and year built.
        public string Address { get; set; }
        public string ConstructionType { get; set; }
        public int YearBuild { get; set; }

        public Housing(string address, string constType, int yrBuild)
        {
            Address = address;
            ConstructionType = constType;
            YearBuild = yrBuild;

        }

        //Contains a virtual method named ProjectedRentalAmt, returns decimal. Create this method in the base class to return 0.
        public virtual decimal ProjectedRentalAmt()
        {
            return 0M;
        }

        //Contains an override ToString method that prints all of the relevant class information as a string.
        public override string ToString()
        {
            string propertyInfo = $"The adress of the property is: {Address}" +
                $"\nConstruction type: {ConstructionType}" +
                $"\nYear of build: {YearBuild}";
            return propertyInfo;
        }


    }
}
