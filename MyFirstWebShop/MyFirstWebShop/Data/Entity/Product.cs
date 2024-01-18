using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebShop.Data.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, StringLength(150)]
        public string ProductName { get; set; }

        [Required, StringLength(500)]
        public string? ProductDescription { get; set; }

        [Required, Column(TypeName = "decimal(8,3)")]
        public decimal ProductPrice { get; set; }

        [Column(TypeName = "decimal(5,4)")]
        public decimal? Discount { get; set; }

        public ICollection<OrderPos> Orders { get; set; } = new List<OrderPos>();
    }
}
