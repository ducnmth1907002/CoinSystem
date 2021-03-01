using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public CurrencyStatus Status { get; set; }
    }

    public enum CurrencyStatus
    {
        Active, Deactive
    }
}