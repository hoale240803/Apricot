using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Apricot.Domain.Aggregate.User
{
    public interface IUserRepository
    {
        Task Login(LoginModel model);
    }
}
