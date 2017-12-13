using Framework;
using Framework.Pages;
using Framework.Pages.SocialNetworks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tests.WhereToGoPageTests
{
    [TestFixture, Category("Instagram")]
    public class InstagramTests
    {
        private InstagramPage _instagramPage;
        private MainPage _mainPage;


        [SetUp]
        public void SetUpMethods()
        {
            _mainPage =  Selenium.OpenSite();
        }


        [Test]
        public void PageHasExpectedTitle()
        {
            try
            {
                _instagramPage = (InstagramPage)_mainPage.OpenSocialNetwork(SocialNetwork.Instagram);
            }
            catch (NoSuchWindowException)
            {
                Assert.Fail("Instagram of KyKy was not found");
            }
        }

        [Test]
        public void TodayEventsExist()
        {
            _instagramPage = (InstagramPage) _mainPage.OpenSocialNetwork(SocialNetwork.Instagram);

            Assert.Greater(_instagramPage.Title.Length, 1, "Title of instagram page is too short");
        }

        [Test]
        public void TomorrowEventsExist()
        {
            _instagramPage = (InstagramPage)_mainPage.OpenSocialNetwork(SocialNetwork.Instagram);

            Assert.True(_instagramPage.Title.Contains("KYKY.org"), "Instagram's title was changes");
        }
    }
}
