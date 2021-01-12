using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FernveeAIT.Models
{
    public class LibraryModelContext : DbContext
    {
        public LibraryModelContext() : base("LibraryModelContext")
        {

        }

        public DbSet<Venue> venues { get; set; }
        public DbSet<Concert> concerts { get; set; }
    }
}