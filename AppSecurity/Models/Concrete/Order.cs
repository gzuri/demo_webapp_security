using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSecurity.Models.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime DateCreated { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingName { get; set; }
        public string ContactEmail { get; set; }
        public string Item { get; set; }
        public string Mobile { get; set; }
        public double Amount { get; set; }
    }
}