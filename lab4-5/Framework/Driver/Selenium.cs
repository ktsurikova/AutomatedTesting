using Framework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Selenium
    {
        private static IWebDriver _instance;
        private static string Url = @"http://kyky.org/";


        public static IWebDriver Driver
        {
            get { return _instance ?? (_instance = new ChromeDriver(ChromeLangOptions)); }
        }

        public static MainPage OpenSite()
        {
            Driver.Navigate().GoToUrl(Url);

            return new MainPage();
        }


        #region MyRegion

        private static ChromeOptions ChromeLangOptions
        {
            get
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--lang=en");

                return options;
            }
        }

        #endregion
    }
}