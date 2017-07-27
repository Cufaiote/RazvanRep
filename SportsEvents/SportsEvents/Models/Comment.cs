using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsEvents.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public virtual List<Event> Event { get; set; }
        public int EventId { get; set; }
    }
}