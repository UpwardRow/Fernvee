using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FernveeAIT.Models
{
    public class Concert
    {
        private ICollection<Venue> _venues;

        public Concert()
        {
            _venues = new List<Venue>();
        }

        public int ConcertId { get; set; }
        public string Name { get; set; }
        public int AgeRating { get; set; }
        public DateTime BookedFor { get; set; }
        
        public virtual ICollection<Venue> Venues
        {
            get { return _venues; }
            set { _venues = value; }
        }
    }
}