using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
        public ICollection<Subscribe> Subscribes { get; set; }
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

    public class UserInfo
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public UserStatus Status { get; set; }
        public SubscribeType? SubscribeType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}