using Framework.Pages.Constants;
using Framework.Pages.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using Framework.Pages.SocialNetworks;

namespace Framework.Pages
{
    public class MainPage : BasePage, IMainPage
    {
        [FindsBy(How = How.ClassName, Using = PageLocators.AllArticlesClassName)]
        public IList<IWebElement> AllArticles;

        [FindsBy(How = How.XPath, Using = PageLocators.LogoXpath)]
        private IWebElement Logo;

        [FindsBy(How = How.XPath, Using = PageLocators.AllSocialNetworkIconsXpath)]
        public IList<IWebElement> SocialIcons;


        #region Overrides

        public override void WaitUntilReady()
        {
            WaitUntilElementExists(By.XPath(@"(//form[contains(@class,'feedback__form')]//*[@id='email' and @placeholder])[1]"));
        }

        #endregion


        public MainPage()
        {
            PageFactory.InitElements(Driver, this);
        }


        public ArticlePage OpenArticle(string articleTitle)
        {
            GetArticleLink(articleTitle).Click();

            return new ArticlePage();
        }

        public BasePage OpenSection(Sections sectionName)
        {
            throw new NotImplementedException();
        }

        public BasePage OpenSubsection(Subsections subsectionName)
        {
            throw new NotImplementedException();
        }

        public int CountOfArticles
        {
            get { return Driver.FindElements(By.TagName("article")).Count; }
        }

        public bool IsLogoDisplayed
        {
            get { return Logo.Displayed; }
        }


        public int CountOfSocialNetworkIcons
        {
            get { return SocialIcons.Count; }
        }

        public BasePage OpenSocialNetwork(SocialNetwork socialNetworkName)
        {
            ClickIcon(socialNetworkName);

            switch (socialNetworkName)
            {
                case SocialNetwork.Instagram:
                    return new InstagramPage();

                default:
                    throw new NotImplementedException();
            }
        }

        #region Private Methods

        private IWebElement GetArticleLink(string articleTitle)
        {
            IWebElement link;

            try
            {
                link = Driver.FindElement(By.XPath(@"//article//*[contains(text(), '" + articleTitle + "')]/../.."));
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(String.Format("Link for article with text {0} was not found on the main page",
                    articleTitle));
            }

            return link;
        }

        private void ClickIcon(SocialNetwork sectionName)
        {
            string smallPath;

            switch (sectionName)
            {
                case SocialNetwork.Instagram:
                    smallPath = "ig";
                    break;

                case SocialNetwork.Facebook:
                    smallPath = "fb";
                    break;

                case SocialNetwork.Vkontakte:
                    smallPath = "vk";
                    break;

                case SocialNetwork.Twitter:
                    smallPath = "tw";
                    break;

                default:
                    throw new NotImplementedException();
            }

            string hrefXpath = String.Format(@"//div[@class='layout__hide-before--lg']//a[@class='socicons__icon--{0}']",
                smallPath);

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.document.evaluate(\"" + hrefXpath +
                            "\", window.document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.click();");

        }

        #endregion
    }


    public enum Sections
    {

    }

    public enum Subsections
    {

    }

    public enum SocialNetwork
    {
        Facebook,
        Vkontakte,
        Twitter,
        Instagram
    }
}
