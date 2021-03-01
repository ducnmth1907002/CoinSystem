using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
        public ICollection<Subscribe> Subscribes { get; set; }
    }

    public enum UserRole
    {
        User, Admin, Author
    }

    public enum UserStatus
    {
        Active, Deactive
    }
}