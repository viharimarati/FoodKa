using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyNew_FOODWEBAPI.Model
{
    public partial class OrderItem
    {
        [Key]
        [Column("OrderItemID")]
        public long OrderItemId { get; set; }
        public int? Quantity { get; set; }
        [Column("OrderID")]
        public long? OrderId { get; set; }
        [Column("ItemID")]
        public int? ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        [InverseProperty("OrderItems")]
        public virtual Item Item { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderItems")]
        public virtual Order Order { get; set; }
    }
}
