using Auth.Core.Contract;
using Auth.Core.Entities;
using Auth.Core.Helpers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Core.Services
{
    public class UserService : Service , IUserAuth
    {
        private readonly IOptions<AppSettings> _appSettings;
        public UserService(ILogger logger , IOptions<AppSettings> appSettings) : base(logger)
        {
            _appSettings = appSettings;
        }

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(AuthenticateAsync));
            var userAuth = new UserAuth(_appSettings);
            try
            {
                var user = await userAuth.AuthenticateAsync(username, password);
                return user; 
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var userAuth = new UserAuth(_appSettings);
            try
            {
                var allUsers =  await userAuth.GetAll();
                return allUsers;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
