using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsEvents.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250,MinimumLength = 3)]
        public string EventName { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 3)]
        public string Sport { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}