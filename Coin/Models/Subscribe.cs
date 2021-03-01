﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SubscribeType Type { get; set; }
        public virtual User User { get; set; }
    }

    public enum SubscribeType
    {
        Bronze, Silver, Gold
    }
}