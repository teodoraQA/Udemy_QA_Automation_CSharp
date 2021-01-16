using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Housing_Application
{
    [TestClass]
    public class Housing_Application_Tests
    {
        [TestMethod]
        public void Single_Family_Test()
        {
            /*Create a test method that creates 5 instances of the SingleFamily class using the constructor. 
            Put these into a List<SingleFamily>.*/

            List<SingleFamily> familyList = new List<SingleFamily>(5);
            familyList.Add(new SingleFamily( "34 Winston Street", "Colonial", 1997, 900.00M, 100,
                3, 3, true, true));
            familyList.Add(new SingleFamily( "5234 Carolina Ave", "Ranch", 1979, 850.00M, 80,
                2, 1, true, false));
            familyList.Add(new SingleFamily( "54 Magnolia Court", "Craftsman", 2004, 1000.00M, 150,
                3, 2, false, true));
            familyList.Add(new SingleFamily( "6910 Reiley", "Colonial", 2001, 750.00M, 75,
                2, 2, false, false));
            familyList.Add(new SingleFamily( "76 St. Johns Ct.", "Ranch", 2015, 1500.00M, 120,
                4, 3, true, true));

            foreach (var item in familyList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void MultiUnits_Test()
        {
            List<MultiUnit> multiUnits = new List<MultiUnit>(5);
            multiUnits.Add(new MultiUnit("34 Winston Street", "Colonial", 2011, "Laurel Springs", 2, 450.00M));
            multiUnits.Add(new MultiUnit("9724 Bridge Street", "Apartments", 2001, "Dover Grove", 20, 550.00M));
            multiUnits.Add(new MultiUnit("2310 Reiley Lane", "Apartments", 1998, "Lemon Square", 44, 400.00M));
            multiUnits.Add(new MultiUnit("74 Winston Ave", "Apartments", 2015, "Ducks Head", 16, 600.00M));
            multiUnits.Add(new MultiUnit("1112 Mary Lane", "Duplex", 2016, "Geneva Springs", 2, 750.00M));

            foreach (var item in multiUnits)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void Combined_Test()
        {
            List<Housing> combinedList = new List<Housing>(10);
            combinedList.Add(new SingleFamily("34 Winston Street", "Colonial", 1997, 900.00M, 100,
                3, 3, true, true));
            combinedList.Add(new SingleFamily("5234 Carolina Ave", "Ranch", 1979, 850.00M, 80,
                2, 1, true, false));
            combinedList.Add(new SingleFamily("54 Magnolia Court", "Craftsman", 2004, 1000.00M, 150,
                3, 2, false, true));
            combinedList.Add(new SingleFamily("6910 Reiley", "Colonial", 2001, 750.00M, 75,
                2, 2, false, false));
            combinedList.Add(new SingleFamily("76 St. Johns Ct.", "Ranch", 2015, 1500.00M, 120,
                4, 3, true, true));
            combinedList.Add(new MultiUnit("34 Winston Street", "Colonial", 2011, "Laurel Springs", 2, 450.00M));
            combinedList.Add(new MultiUnit("9724 Bridge Street", "Apartments", 2001, "Dover Grove", 20, 550.00M));
            combinedList.Add(new MultiUnit("2310 Reiley Lane", "Apartments", 1998, "Lemon Square", 44, 400.00M));
            combinedList.Add(new MultiUnit("74 Winston Ave", "Apartments", 2015, "Ducks Head", 16, 600.00M));
            combinedList.Add(new MultiUnit("1112 Mary Lane", "Duplex", 2016, "Geneva Springs", 2, 750.00M));

            foreach (var item in combinedList)
            {
                Console.WriteLine(item.Address + $"\nProjected Annual Rent: {item.ProjectedRentalAmt():C2}");
                Console.WriteLine();
            }

        }
    }
}
