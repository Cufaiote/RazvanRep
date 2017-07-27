using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesDatabase.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string LocationName { get; set; }

        public List<Sale> Sales { get; set; }

    }
}