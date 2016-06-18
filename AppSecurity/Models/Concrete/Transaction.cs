using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSecurity.Models.Concrete
{
    public class Transaction
    {
        public int ID { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreditCardNumber { get; set; }
    }
}