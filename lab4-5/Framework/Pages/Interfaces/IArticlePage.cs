namespace Framework.Pages.Interfaces
{
    public interface IArticlePage
    {
        bool IsTextExistInArticle();
        bool IsPictureExist();
        bool IsCommentExist();
        string CommentText(int commentNumber);
        string Title { get; }
        string Author { get; }
    }
}
