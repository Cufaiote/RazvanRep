using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesDatabase.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        public float Quantity { get; set; }

        public float Price { get; set; }

        public List<Sale> Sales { get; set; }

    }
}