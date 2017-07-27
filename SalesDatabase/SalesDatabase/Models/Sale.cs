using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesDatabase.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public int StoreLocationId { get; set; }

        public DateTime Date { get; set; }

        public Product Product { get; set; }

        public Customer Customer { get; set; }

        public StoreLocation StoreLocation { get; set; }
    }
}