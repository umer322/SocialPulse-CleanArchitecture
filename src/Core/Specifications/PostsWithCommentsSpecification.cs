using Ardalis.Specification;
using Core.Entities.PostAggregate;

namespace Core.Specifications
{
    public class PostsWithCommentsSpecification : Specification<Post>
    {
        public PostsWithCommentsSpecification()
        {
            Query.Include(p => p.Comments);
        }
    }
}
