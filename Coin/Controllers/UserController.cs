using Coin.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Coin.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        private AuthRepository _repo = null;
        protected CoinDbContext coinDbContext { get; set; }
        protected UserManager<User> userManager { get; set; }
        public UserController()
        {
            _repo = new AuthRepository();
            this.coinDbContext = new CoinDbContext();
            this.userManager = new UserManager<User>(new UserStore<User>(this.coinDbContext));
        }

        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(User userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await _repo.RegisterUser(userModel);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok(result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

        [Authorize]
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [Route("UserInfo")]
        public User GetUserInfo()
        {            
            var userName = User.Identity.GetUserName();
            var user = userManager.FindByName(userName);
            
            return new Models.User
            {
                Id = user.Id,
                UserName = user.UserName,
                Phone = user.Phone,
                Email = user.Email,
                Status = user.Status,
                Subscribes = user.Subscribes,
            };           
        }
    }
}

