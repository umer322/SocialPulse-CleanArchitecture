using Ardalis.GuardClauses;
using Core.Entities.PostAggregate;
using Core.Interfaces;

namespace Core.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;

        public PostService(IRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Post> AddCommentToPost(string Comment, int UserId, int PostId)
        {
            var post = await _postRepository.GetByIdAsync(PostId);
            Guard.Against.Null(post);
            post.AddComment(Comment, UserId);
            await _postRepository.UpdateAsync(post);
            return post;
        }

        public async Task AddPost(string Title, string Description, int UserId)
        {
            await _postRepository.AddAsync(new Post(Title, Description, UserId));

        }

        public async Task<Post> DeleteComment(int Id, int PostId)
        {
            var post = await _postRepository.GetByIdAsync(PostId);
            Guard.Against.Null(post);
            post.RemoveComment(Id);
            await _postRepository.UpdateAsync(post);
            return post;
        }

        public async Task DeletePost(Post post)
        {
            await _postRepository.DeleteAsync(post);
        }


    }
}
