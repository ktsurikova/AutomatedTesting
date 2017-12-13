using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.CommonArticles
{
    [TestFixture, Category("Article")]
    public class CommonArticlesTests
    {
        private ArticlePage _articlePage;
        private readonly string _articleTitle = "что";

        [SetUp]
        public void SetUpMethods()
        {
            var mainPage = Selenium.OpenSite();
            _articlePage = mainPage.OpenArticle(_articleTitle);
        }

        [Test]
        public void IsParagraphExist()
        {
            Assert.True(_articlePage.IsTextExistInArticle(), "No paragraphs were found in the article " + _articleTitle);
        }
        
        [Test]
        public void IsTitleNotTooShort()
        {
            Assert.Greater(_articlePage.Title.Length, 1, "Title of the article with title {0} is too short", _articleTitle);
        }
        
        [Test]
        public void IsAuthorDisplayed()
        {
            Assert.Greater(_articlePage.Author.Length, 1, "Name of author of of the article with title {0} is too short", _articleTitle);
        }
    }
}
