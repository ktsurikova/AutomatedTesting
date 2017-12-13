namespace Framework.Pages.Interfaces
{
    public interface IMainPage
    {
        ArticlePage OpenArticle(string articleTitle);
        BasePage OpenSection(Sections sectionName);
        BasePage OpenSocialNetwork(SocialNetwork socialNetworkName);
        int CountOfArticles { get; }
        bool IsLogoDisplayed { get; }
        int CountOfSocialNetworkIcons { get; }
    }
}
