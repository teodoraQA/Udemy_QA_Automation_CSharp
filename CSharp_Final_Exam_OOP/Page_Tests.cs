using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharp_Final_Exam_OOP
{
    [TestClass]
    public class Page_Tests
    {
        [TestMethod]
        public void ComplicatedPage_Test()
        {
            /*Write a test method that creates an instance of ComplicatedPage. 
             Using the created instance, return the property PageName. 
            Assert that it contains the string "Complicated Page"*/

            ComplicatedPage newPAge = new ComplicatedPage();
            Assert.AreEqual("Complicated Page", newPAge.PageName);
        }

        [TestMethod]
        public void RandomStuff_Test()
        {
            /*Write a test method that creates an instance of SectionOfRandomStuff. 
            Using the created instance, call the FillForm() method.*/

            SectionOfRandomStuff rndStuff = new SectionOfRandomStuff();
            rndStuff.FillForm();
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void Buttons_Test_Fail()
        {
            /*Write a test method that creates an instance of SectionOfButtons. Using the created instance, 
            call the Click() method of the instance’s Button property. Wrap the contents of this test method in a 
            try/catch and be sure to write out an error message that occurs, if any.*/

            SectionOfButtons sectionButton = new SectionOfButtons();
            try
            {
                sectionButton.Button.Click();
            }
            catch
            {
                Console.WriteLine("Referenced null element");
                throw new NullReferenceException();
            }
        }
    }
}
