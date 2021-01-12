using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FernveeAIT.Models
{
    public class Venue
    {
        private ICollection<Concert> _concerts;

        public Venue()
        {
            _concerts = new List<Concert>();
        }

        public int VenueId {get; set;}
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Concert> Concerts
        {
            get { return _concerts; }
            set { _concerts = value; }
        }
    }
}