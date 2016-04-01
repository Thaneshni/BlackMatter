using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rangamo.Models
{
    public class InventoryItems
    {
        [Key]
        public int InventoryId { get; set; }
        public int ReOrderQuantity { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        [Column("Quantity On Hand")]
        [Display(Name = "Quantity On Hand")]
        public int QuantityOnHand { get; set; }


    }
}