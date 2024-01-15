using Core.Entities.PostAggregate;

namespace Core.Interfaces
{
    public interface IPostService
    {
        Task AddPost(string Title, string Description, int UserId);
        Task DeletePost(Post post);
        Task<Post> AddCommentToPost(string Comment, int UserId, int PostId);
        Task<Post> DeleteComment(int Id, int PostId);
    }
}
