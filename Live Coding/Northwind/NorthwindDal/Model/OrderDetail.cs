using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NorthwindDal.Model
{
    [Table("order_details")]
    public partial class OrderDetail
    {
        [Key]
        [Column("order_id")]
        public short OrderId { get; set; }
        [Key]
        [Column("product_id")]
        public short ProductId { get; set; }
        [Column("unit_price")]
        public float UnitPrice { get; set; }
        [Column("quantity")]
        public short Quantity { get; set; }
        [Column("discount")]
        public float Discount { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; } = null!;
        [ForeignKey("ProductId")]
        [InverseProperty("OrderDetails")]
        public virtual Product Product { get; set; } = null!;
    }
}
