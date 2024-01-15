namespace Core.Entities.PostAggregate
{
    public class PostComment : BaseEntity<int>
    {
        public string Comment { get; protected set; }
        public int UserId { get; protected set; }
#pragma warning disable
        private PostComment() { }

        public PostComment(string comment, int UserId)
        {
            this.Comment = comment;
            this.UserId = UserId;
        }
    }
}
