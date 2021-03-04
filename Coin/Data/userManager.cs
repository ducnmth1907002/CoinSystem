using Coin.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin.Data
{
    public class userManager : UserManager<ApplicationUser>
    {
        public userManager(IUserStore<ApplicationUser> store) : base(store)
        {
        }

        public static userManager Create(IdentityFactoryOptions<userManager> options, IOwinContext context)
        {
            CoinDbContext dbContext = context.Get<CoinDbContext>();
            userManager manager = new userManager(new UserStore<ApplicationUser>(dbContext));

            manager.UserValidator = new UserValidator<ApplicationUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = true,
                RequireUniqueEmail = true
            };

            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 8,
                RequireDigit = false,
                RequireNonLetterOrDigit = false,
                RequireLowercase = false,
                RequireUppercase = false
            };

            return manager;
        }
    }
}