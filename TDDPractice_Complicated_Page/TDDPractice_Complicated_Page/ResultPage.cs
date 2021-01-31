using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TDDPractice_Complicated_Page
{
    internal class ResultPage: BasePage
    {
        public ResultPage(IWebDriver driver) : base(driver) { }
        

        internal string GetResultPageUrl()
        {
            return Driver.Url;
        }

        internal string SearchResultsKeyword()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//mark")));
            return Driver.FindElement(By.XPath("//mark")).Text.ToLower();
        }
    }
}