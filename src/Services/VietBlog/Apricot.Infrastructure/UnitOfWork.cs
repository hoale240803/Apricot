using Apricot.Domain.Aggregate.Blog;
using Apricot.Domain.Aggregate.User;
using Apricot.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;

namespace Apricot.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IBlogRepository _blogRepository;

        private readonly IUserRepository _userRepository;

        private readonly ApricotDbContext _dbContext;

        public UnitOfWork(ApricotDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task SaveChangeAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public IBlogRepository Blogs
        {
            get
            {
                return _blogRepository != null ? _blogRepository : new BlogRepository(_dbContext);
            }
        }

        public IUserRepository Users
        {
            get
            {
                return _userRepository != null ? _userRepository : new UserRepository(_dbContext);
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
            {
                _dbContext.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}