using System.Threading.Tasks;

namespace Apricot.Domain.Aggregate.Blog
{
    public interface IBlogRepository
    {
        Task<Blog> AddBlog(Blog blog);
    }
}