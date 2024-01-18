using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebShop.Data.Entity
{
    public class Order
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Customer Customer { get; set; }

        [Required, Column(TypeName = "decimal(5,4)")]
        public decimal Discound { get; set; }

        [Required, StringLength(250)]
        public string InvAddress { get; set; }

        [StringLength(500)]
        public string? notes { get; set; }

        public ICollection<OrderPos> orderPos { get; set; } = new List<OrderPos>();
    }
}
