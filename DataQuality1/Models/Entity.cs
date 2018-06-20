using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataQuality1.Models
{
    public class Entity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class EntityDBContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }
    }
}