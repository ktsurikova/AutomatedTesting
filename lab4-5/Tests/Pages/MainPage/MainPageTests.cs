using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.MainPageTests
{
    [TestFixture, Category("Main")]
    public class MainPageTests
    {
        private MainPage _mainPage;


        [SetUp]
        public void SetUpMethods()
        {
            _mainPage = Selenium.OpenSite();
        }


        [Test]
        public void ArticlesExistOnPage()
        {
            Assert.Greater(_mainPage.CountOfArticles, 0, "No articles were found on the main page");
        }

        [Test]
        public void LogoExistsOnPage()
        {
            Assert.True(_mainPage.IsLogoDisplayed, "Logo is not displayed on the main page");
        }

        [Test]
        public void SocialNetworkIconsExist()
        {
            Assert.AreEqual(4, _mainPage.CountOfSocialNetworkIcons, "Count of social networks items is incorrect on the main page");
        }
    }
}
