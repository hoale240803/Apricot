using Apricot.Domain.Aggregate.User;
using System;
using System.Threading.Tasks;

namespace Apricot.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApricotDbContext _dbContext;

        public UserRepository(ApricotDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Login(LoginModel model)
        {
            throw new NotImplementedException();
        }
    }
}