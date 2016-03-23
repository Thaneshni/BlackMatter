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
        public RangamoContext() : base("RangData") { }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}