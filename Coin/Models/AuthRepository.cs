using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Coin.Models
{
    public class AuthRepository : IDisposable
    {
        private CoinDbContext _ctx;

        private UserManager<User> _userManager;

        public AuthRepository()
        {
            _ctx = new CoinDbContext();
            _userManager = new UserManager<User>(new UserStore<User>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(User userModel)
        {
            User user = new User
            {
                UserName = userModel.UserName,
                Phone = userModel.Phone,
                Name = userModel.Name,
                Email = userModel.Email,
                Role = UserRole.Admin,
                Status = UserStatus.Deactive
            };

            var result = await _userManager.CreateAsync(user, userModel.PasswordHash);

            return result;
        }

        public async Task<User> FindUser(string userName, string password)
        {
            User user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}