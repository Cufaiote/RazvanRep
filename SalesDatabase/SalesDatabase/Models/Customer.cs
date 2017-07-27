using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesDatabase.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Email { get; set; }

        [StringLength(19, MinimumLength = 19)]
        public string CreditCardNumber { get; set; }

        public List<Sale> Sales { get; set; }

    }
}