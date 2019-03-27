using Auth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Core.Contract
{
    public interface IUserAuth
    {
        Task<User> AuthenticateAsync(string username, string password);
        Task<IEnumerable<User>> GetAll();
    }
}
