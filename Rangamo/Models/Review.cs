using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rangamo.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int CustomerId { get; set; }
        public string ReviewSummary { get; set; }
        public virtual Product product { get; set; }
    }
}