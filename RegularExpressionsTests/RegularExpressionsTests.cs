using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System;

namespace RegularExpressionsTests
{
    [TestClass]
    public class RegularExpressionsTests
    {
        [TestMethod]
        public void TestFirstName()
        {
            string fName = "Teodora";
            string pattern = @"^[A-Z][a-z]*$";
            bool isMatch = Regex.IsMatch(fName, pattern);
            if (isMatch)
            {
                Assert.IsTrue(isMatch);
            }
            else
            {
                Console.WriteLine("Incorrect name insertion!");
            }
        }

        [TestMethod]
        public void TestLastName()
        {
            string fName = "georgieva";
            string pattern = @"^[A-Z][a-z]*$";
            bool isMatch = Regex.IsMatch(fName, pattern);
            try
            {
                Assert.IsTrue(isMatch);
            }
            catch (AssertFailedException)
            {
                Console.WriteLine("Incorrect name insertion!\nName should start with upper case letter.");
            }
        }

        [TestMethod]
        public void TestAgeFail()
        {
            int age = 225;
            string strAge = Convert.ToString(age);
            string pattern = @"^[1-9][0-9]?$";
            bool isAgeValid = Regex.IsMatch(strAge, pattern);
            try
            {
                Assert.IsTrue(isAgeValid);
            }
            catch (AssertFailedException)
            {
                Console.WriteLine("Input age is not valid!\nAge should contain only numbers- 1 or 2 numbers");
            }

        }

        [TestMethod]
        public void TestAgePass()
        {
            int age = 25;
            string strAge = Convert.ToString(age);
            string pattern = @"^[1-9][0-9]?$";
            bool isAgeValid = Regex.IsMatch(strAge, pattern);
            try
            {
                Assert.IsTrue(isAgeValid);
            }
            catch (AssertFailedException)
            {
                Console.WriteLine("Input age is not valid!\nAge should contain only numbers- 1 or 2 numbers");
            }
        }

        [TestMethod]
        public void TestBirthDate()
        {
            int day = 28;
            int month = 12;
            int year = 1998;

            string dob = Convert.ToString(day) + "/" + Convert.ToString(month) + "/" + Convert.ToString(year);
            string pattern = @"(?<day>[012][1-9]|3[01])[- \/.](?<month>0[1-9]|1[0-2])[- \/.](?<year>19[0-9]{2}|20[0-9]{2})$";
            Regex regex = new Regex(pattern);
            bool isAgeValid = Regex.IsMatch(dob, pattern);
            try
            {
                Assert.IsTrue(isAgeValid);
                MatchCollection matches = Regex.Matches(dob, pattern);
                foreach (Match date in matches)
                {
                    Console.WriteLine($"Day: {date.Groups["day"].Value}\n" +
                        $"Month: {date.Groups["month"].Value}\n" +
                        $"Year: {date.Groups["year"].Value}");
                }

            }
            catch (AssertFailedException)
            {
                Console.WriteLine("Input data is not valid!\nValid input shoud be in the following format: DD/MM/YYYY");
            }

        }

        [TestMethod]
        public void TestBirthDateFail()
        {
            int day = 32;
            int month = 13;
            int year = 1998;

            string dob = Convert.ToString(day) + "/" + Convert.ToString(month) + "/" + Convert.ToString(year);
            string pattern = @"(?<day>[012][1-9]|3[01])[- \/.](?<month>0[1-9]|1[0-2])[- \/.](?<year>19[0-9]{2}|20[0-9]{2})$";
            Regex regex = new Regex(pattern);
            bool isAgeValid = Regex.IsMatch(dob, pattern);
            try
            {
                Assert.IsTrue(isAgeValid);
                MatchCollection matches = Regex.Matches(dob, pattern);
                foreach (Match date in matches)
                {
                    Console.WriteLine($"Day: {date.Groups["day"].Value}\n" +
                        $"Month: {date.Groups["month"].Value}\n" +
                        $"Year: {date.Groups["year"].Value}");
                }

            }
            catch (AssertFailedException)
            {
                Console.WriteLine("Input data is not valid!\nValid input shoud be in the following format: DD/MM/YYYY");
            }
        }

        [TestMethod]
        public void TestPhoneNumber()
        {
            string phoneNum = "(359)-852-1234";
            string pattern = @"^\(\d{3}\)-\d{3}-\d{4}$";
            bool isPhoneValid = Regex.IsMatch(phoneNum, pattern);
            try
            {
                Assert.IsTrue(isPhoneValid);
            }
            catch (AssertFailedException)
            {
                Console.WriteLine("Input phone number is not valid!\nCorrect phone format is: (###)-###-####");
            }
        }
    }
}
