using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class User : IdentityUser
    {
        //[Key]
        //public int UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        //[Required]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }
        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        //public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
        public ICollection<Subscribe> Subscribes { get; set; }
        public ICollection<News> News { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }


    public enum UserRole
    {
        User, Admin, Author
    }

    public enum UserStatus
    {
        Active, Deactive
    }

    public class UserInfoViewModel
    {
        public string Email { get; set; }
    }

}