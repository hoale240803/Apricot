using Apricot.Domain.Aggregate.Blog;

namespace Apricot.API.Services
{
    public interface IBlogService
    {
        Task<Blog> AddBlogAsync(Blog blog);

        Task<Blog> UpdateBlog(Blog blog);

        Task<List<Blog>> GetBlogs();
    }
}
