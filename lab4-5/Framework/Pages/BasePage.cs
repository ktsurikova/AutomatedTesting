using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public abstract class BasePage
    {
        private const string Url = @"http://kyky.org/";
        private WebDriverWait _wait;


        protected BasePage()
        {
            WaitUntilReady();
        }


        public IWebDriver Driver
        {
            get
            {
                return Selenium.Driver;
            }
        }

        public MainPage OpenMainPage()
        {
            Driver.Navigate().GoToUrl(Url);

            return new MainPage();
        }

        public IWebElement WaitUntilElementExists(By by)
        {
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            return _wait.Until(ExpectedConditions.ElementExists(by));
        }

        public abstract void WaitUntilReady();
    }
}
