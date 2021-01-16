using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Application
{
    class SingleFamily : Housing
    {
        /* Single- Family should include characteristics such as the rent amount, size in square feet, 
          number of bedrooms, number of bathrooms, whether there is a porch, and availability of garage.*/

        public decimal RentAmount { get; set; }
        public int Size { get; set; }
        public int BedroomsNum { get; set; }
        public int BathroomsNum { get; set; }
        public bool PorchIsPresent { get; set; }
        public bool GarageIsPresent { get; set; }

        public SingleFamily(string address, string constType, int yrBuild, decimal rentAmt, int size, int bedroomsCount,
            int bathroomsCount, bool porch, bool garage) :
            base(address, constType, yrBuild)
        {
            RentAmount = rentAmt;
            Size = size;
            BedroomsNum = bedroomsCount;
            BathroomsNum = bathroomsCount;
            PorchIsPresent = porch;
            GarageIsPresent = garage;
        }

        /*Contains an override method ProjectedRentalAmt(), returns a decimal. 
        Take the rent amount multiplied by 12 months.*/

        public override decimal ProjectedRentalAmt()
        {
            return RentAmount * 12;
        }

        /*Contains an override ToString method that prints all of the relevant class information as a string.*/

        public override string ToString()
        {
            string singleFamilyInfo = base.ToString() +
                $"\nSize in square feet: {Size}" +
                $"\nNumber of bedrooms: {BedroomsNum}" +
                $"\nNumber of bathrooms: {BathroomsNum}";

            if(PorchIsPresent)
            {
                singleFamilyInfo += "\nPorch is present";
            }

            if (GarageIsPresent)
            {
                singleFamilyInfo += "\nGarage is present";
            }

            singleFamilyInfo += $"\nMonthlty Rental Rate: {RentAmount:C2}" +
                $"\nExpected Annual Rent: {ProjectedRentalAmt():C2}";

            return singleFamilyInfo;
        }
        

    }
}
