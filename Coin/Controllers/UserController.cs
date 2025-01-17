﻿using Coin.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
        public UserInfo GetUserInfo()
        {
            SubscribeType? subscribeType = null;
            var userName = User.Identity.GetUserName();
            var user = userManager.FindByName(userName);
          
            var subscribe = coinDbContext.Subscribes.FirstOrDefault(s => s.UserId == user.Id);
            if (subscribe != null)
            {
                if (subscribe.StartDate <= DateTime.Now && subscribe.EndDate >= DateTime.Now && subscribe.Status != SubscribeStatus.Deactive)
                {
                    subscribeType = subscribe.Type;
                }     
            }
           
            return new UserInfo()
            {
                Email = user.Email,
                UserName = user.UserName,
                Phone = user.Phone,
                Status = user.Status,
                SubscribeType = subscribeType,
                CreatedAt = (DateTime)user.CreatedAt,
                UpdatedAt = (DateTime)user.UpdatedAt
            };
        }

        [Authorize]
        [HttpPost]
        [Route("register-vip")]
        public Subscribe RegsterVip(int type)
        {
            string randomCode = Path.GetRandomFileName();
            randomCode = randomCode.Replace(".", "");
            var userName = User.Identity.GetUserName();
            var user = userManager.FindByName(userName);
            var userSubscribe = coinDbContext.Subscribes.FirstOrDefault(s => s.UserId == user.Id);
            var userSub = new Subscribe()
            {
                UserId = user.Id,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(30),
                Code = randomCode,
                Type = (SubscribeType)type,
                Status = SubscribeStatus.Deactive,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            if (userSubscribe == null)
            {              
                coinDbContext.Subscribes.Add(userSub);
                coinDbContext.SaveChanges();
                return userSub;
            }
            
            userSub.Id = userSubscribe.Id;
            coinDbContext.Entry(userSubscribe).CurrentValues.SetValues(userSub);
            coinDbContext.SaveChanges();
            return userSub;
        }
    }
}

