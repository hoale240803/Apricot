using Apricot.Domain.Aggregate.User;

namespace Apricot.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task Login(LoginModel model)
        {
            return _userRepository.Login(model);
        }
    }
}
