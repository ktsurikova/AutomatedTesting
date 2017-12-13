namespace Framework.Pages.Constants
{
    public class PageLocators
    {
        #region Main Page

        public const string AllArticlesClassName = @"article";
        public const string LogoXpath = @"//a[@class='header__logo']/*";
        public const string AllSocialNetworkIconsXpath = @"(//div[@class='socicons -black'])[1]/a[contains(@class, 'socicons')]";

        #endregion

        #region Article Page

        public const string TitleXpath = @"//article//*[@class='article__title']";
        public const string ParagrahpsInArticleXpath = @"//article//div[contains(@class, 'section')]//p[text()]";
        public const string AuthorXpath = @"//article//*[@class='article__header__info__editor']";

        #endregion
    }
}
