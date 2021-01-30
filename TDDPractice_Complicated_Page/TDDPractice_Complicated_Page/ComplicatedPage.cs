using OpenQA.Selenium;
using System;

namespace TDDPractice_Complicated_Page
{
    public class ComplicatedPage
    {
        public IWebDriver Driver { get;  }
        public IWebElement SearchBar
        {
            get { return Driver.FindElement(By.XPath("//input[@id='s']")); }
        }
        

        public ComplicatedPage(IWebDriver driver)
        {
            Driver = driver;
        }
        internal void Open()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/complicated-page/");
            Driver.Manage().Window.Maximize();
        }

        internal ResultPage TypeInSearchBar(string textSearch)
        {
            SearchBar.SendKeys("automation testing");
            return new ResultPage(Driver);
        }
    }
}