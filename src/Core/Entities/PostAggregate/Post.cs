using Ardalis.GuardClauses;
using Core.Interfaces;

namespace Core.Entities.PostAggregate
{
    public class Post : BaseEntity<int>, IAggregateRoot
    {
        public int UserId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        private readonly List<PostComment> _comments = new List<PostComment>();
        public IReadOnlyCollection<PostComment> Comments => _comments.AsReadOnly();

#pragma warning disable
        private Post() { }

        public Post(string title, string description, int userId)
        {
            Guard.Against.NullOrEmpty(title);
            Guard.Against.NullOrEmpty(description);
            Guard.Against.OutOfRange(userId, nameof(userId), int.MinValue, int.MaxValue);
            this.Title = title;
            this.Description = description;
            this.UserId = userId;
        }

        public void AddComment(string comment, int UserId)
        {
            Guard.Against.NullOrEmpty(comment);
            _comments.Add(new PostComment(comment, UserId));
        }

        public void RemoveComment(int Id)
        {
            _comments.RemoveAll(c => c.Id == Id);
        }
    }
}
