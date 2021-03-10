using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SubscribeType? Type { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Code { get; set; }
        public SubscribeStatus Status { get; set; }
    }

    public enum SubscribeType
    {
        Bronze, Silver, Gold
    }

    public enum SubscribeStatus
    {
        Deactive, Active
    }
}