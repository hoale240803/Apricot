using Apricot.Domain.Aggregate.User;

namespace Apricot.API.Services
{
    public interface IUserService
    {
        Task Login(LoginModel model);
    }
}
