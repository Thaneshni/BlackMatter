using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rangamo.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public List<Item> Items { get; set; }
        public decimal Charges { get; set; }
        public decimal Cost { get; set; }
        public string DeliveryMethod { get; set; }
        public string PaymentMethod { get; set; }
        public decimal TotalCost { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}