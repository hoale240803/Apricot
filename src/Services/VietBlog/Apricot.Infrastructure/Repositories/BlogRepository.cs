using Apricot.Domain.Aggregate.Blog;
using System.Threading.Tasks;

namespace Apricot.Infrastructure.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ApricotDbContext _dbContext;
        public BlogRepository(ApricotDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Blog> AddBlog(Blog blog)
        {
            throw new System.NotImplementedException();
        }
    }
}