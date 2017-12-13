using System;
using Framework.Pages.SocialNetworks.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages.SocialNetworks
{
    public class InstagramPage : BasePage, ISocialNetworkPage
    {
        #region Overrides

        public override void WaitUntilReady()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.UrlContains("instagram"));
            WaitUntilElementExists(By.XPath("//span[text()=' followers']")); // Followers label
        }

        #endregion

        public void WriteMessage(string messageText)
        {
            throw new NotImplementedException();
        }

        public void LikePost(string postTitle)
        {
            throw new NotImplementedException();
        }

        public void Subscribe()
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe()
        {
            throw new NotImplementedException();
        }

        public string Title
        {
            get { return Driver.Title; }
        }
    }
}
