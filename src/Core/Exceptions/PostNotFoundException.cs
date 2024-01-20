namespace Core.Exceptions
{
    public class PostNotFoundException : Exception
    {
        public PostNotFoundException(int postId) : base($"Post with {postId} is not found") { }
    }
}
