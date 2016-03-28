using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rangamo.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string CellNum { get; set; }
        public ICollection<Order> CustomerHistory { get; set; }
    }
}