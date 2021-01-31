using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;


namespace TDDPractice_Complicated_Page
{
    [TestClass]
    public class ComplicatedPage_Tests
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            var chromeDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            driver = new ChromeDriver(chromeDirectory);
        }

        [TestMethod]
        public void AutomationTesting_Search_Results()
        {
            var complicatedPage = new ComplicatedPage(driver);
            complicatedPage.Open();
            var result = complicatedPage.TypeInSearchBar("automation testing");
            Assert.AreEqual("automation testing", result.SearchResultsKeyword());
            Assert.AreEqual("https://ultimateqa.com/?s=automation%20testing", result.GetResultPageUrl());
        }

        [TestCleanup]

        public void TestClosure()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
