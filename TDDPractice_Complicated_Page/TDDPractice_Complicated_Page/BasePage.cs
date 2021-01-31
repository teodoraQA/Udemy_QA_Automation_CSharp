using OpenQA.Selenium;

namespace TDDPractice_Complicated_Page
{
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}