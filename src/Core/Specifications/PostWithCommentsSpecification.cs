using Ardalis.Specification;
using Core.Entities.PostAggregate;

namespace Core.Specifications
{
    public class PostWithCommentsSpecification : Specification<Post>
    {
        public PostWithCommentsSpecification(int PostId)
        {
            Query.Where(p => p.Id == PostId).Include(p => p.Comments);
        }
    }
}
