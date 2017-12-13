namespace Framework.Pages.SocialNetworks.Interfaces
{
    public interface ISocialNetworkPage
    {
        void WriteMessage(string messageText);
        void LikePost(string postTitle);
        void Subscribe();
        void Unsubscribe();
        string Title { get; }
    }
}
