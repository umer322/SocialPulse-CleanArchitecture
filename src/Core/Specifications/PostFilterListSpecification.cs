using Ardalis.Specification;
using Core.Entities.PostAggregate;

namespace Core.Specifications
{
    public class PostFilterListSpecification : Specification<Post>
    {
        public PostFilterListSpecification(int skip, int take, string searchText = "")
        {
            if (skip < 0)
            {
                skip = 0;
            }
            if (take == 0)
            {
                take = int.MaxValue;
            }

            Query.Where(p => p.Title.ToLower().Contains(searchText.Trim().ToLower())
            || p.Description.ToLower().Contains(searchText.Trim().ToLower())).Skip(skip).Take(take);
        }
    }
}
