using Apricot.Domain.Aggregate.Blog;
using Apricot.Domain.Aggregate.User;
using System.Threading.Tasks;

namespace Apricot.Infrastructure
{
    public interface IUnitOfWork
    {
        IBlogRepository Blogs { get; }
        IUserRepository Users { get; }

        Task SaveChangeAsync();
    }
}