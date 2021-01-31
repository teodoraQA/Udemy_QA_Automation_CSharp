using OpenQA.Selenium;
using System;

namespace TDDPractice_Complicated_Page
{
    public class ComplicatedPage : BasePage
    {
        public IWebElement SearchBar
        {
            get { return Driver.FindElement(By.XPath("//input[@id='s']")); }
        }

        public ComplicatedPage(IWebDriver driver) : base(driver) { }
       
        internal void Open()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/complicated-page/");
            Driver.Manage().Window.Maximize();
        }

        internal ResultPage TypeInSearchBar(string textSearch)
        {
            SearchBar.SendKeys(textSearch);
            return new ResultPage(Driver);
        }
    }
}