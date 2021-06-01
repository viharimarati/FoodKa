using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyNew_FOODWEBAPI.Model
{
    [Table("Item")]
    public partial class Item
    {
        public Item()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        [Column("ItemID")]
        public int ItemId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }

        [InverseProperty(nameof(OrderItem.Item))]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
