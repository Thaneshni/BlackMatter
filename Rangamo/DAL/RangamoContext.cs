using Rangamo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rangamo.DAL
{
    public class RangamoContext:DbContext
    {
        public RangamoContext() : base("mssqllocaldb") { }
        public DbSet<InventoryItems> Inventory { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}