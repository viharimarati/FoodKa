using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyNew_FOODWEBAPI.Model
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        [Column("OrderID")]
        public long OrderId { get; set; }
        [StringLength(50)]
        public string OrderNo { get; set; }
        [Column("PMethod")]
        [StringLength(50)]
        public string Pmethod { get; set; }
        [Column("GTotal", TypeName = "decimal(18, 2)")]
        public decimal? Gtotal { get; set; }
        [Column("CustomerID")]
        public int? CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; }
        [InverseProperty(nameof(OrderItem.Order))]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
