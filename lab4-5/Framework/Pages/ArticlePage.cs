using Framework.Pages.Constants;
using Framework.Pages.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace Framework.Pages
{
    public class ArticlePage : BasePage, IArticlePage
    {
        [FindsBy(How = How.XPath, Using = PageLocators.TitleXpath)]
        private IWebElement TitleElement;

        [FindsBy(How = How.XPath, Using = PageLocators.AuthorXpath)]
        private IWebElement AuthorElement;

        [FindsBy(How = How.XPath, Using = PageLocators.ParagrahpsInArticleXpath)]
        private IList<IWebElement> ParagrahpsInArticle;


        #region Overrides

        public override void WaitUntilReady()
        {
            WaitUntilElementExists(By.XPath("//div[@class='comments__preview']"));
        }

        #endregion


        public ArticlePage()
        {
            PageFactory.InitElements(Driver, this);
        }


        public bool IsTextExistInArticle()
        {
            return ParagrahpsInArticle.Count != 0;
        }

        public string CommentText(int commentNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsPictureExist()
        {
            throw new NotImplementedException();
        }

        public bool IsCommentExist()
        {
            throw new NotImplementedException();
        }
        
        public string Title
        {
            get { return TitleElement.Text; }
        }

        public string Author
        {
            get { return AuthorElement.Text; }
        }
    }
}
