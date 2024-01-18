using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebShop.Data.Entity
{
    [PrimaryKey(nameof(OrderId), nameof(OrderPosNr))]
    public class OrderPos : CreatedModified
    {
        [Required]
        public int OrderId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Order Order { get; set; }
        [Required]
        public int OrderPosNr {  get; set; }

        [Required]
        public int ProductId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Product Product { get; set; }

        [StringLength(250)]
        public string DelAddress { get; set; }
        public DateTime? DelDate { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public string Status { get; set; }

        [Required, Column(TypeName = "decimal(12,4)")]
        public decimal Price { get; set; }

        [Required, Column(TypeName = "decimal(5,4)")]
        public decimal Discount { get; set; }

        [StringLength(500)]
        public string? notes { get; set; }



    }
}
