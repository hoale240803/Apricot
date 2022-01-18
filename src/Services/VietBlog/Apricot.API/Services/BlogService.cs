using Apricot.Domain.Aggregate.Blog;

namespace Apricot.API.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task<Blog> AddBlogAsync(Blog blog)
        {
 
            blog.AddImages(blog.Images.ToList());

            return blog;

        }

        public Task<List<Blog>> GetBlogs()
        {
            throw new NotImplementedException();
        }

        public Task<Blog> UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
