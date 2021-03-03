using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public NewsStatus Status { get; set; }
        public NewsType Type { get; set; }
        public virtual User User { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public enum NewsStatus
    {
        Active, Deactive
    }

    public enum NewsType
    {
        Bronze, Silver, Gold
    }
}