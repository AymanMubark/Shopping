using System;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Entites
{
    public class OrderDetail : Base
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; } = null!;
        public double Price { get; set; } = 0;
        public double Quantity { get; set; } = 1;
        public string SKU { get; set; } = "";
    }
}

