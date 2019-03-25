using Auth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Core.Contract
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
