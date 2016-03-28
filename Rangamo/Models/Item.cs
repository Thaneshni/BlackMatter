using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rangamo.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}