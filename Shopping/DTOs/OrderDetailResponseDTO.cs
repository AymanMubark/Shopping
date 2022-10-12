using System;
using Shopping.Entites;

namespace Shopping.DTOs
{
    public class OrderDetailResponseDTO
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public virtual ProductResponseDTO Product { get; set; } = null!;
        public double Price { get; set; } = 0;
        public double Quantity { get; set; } = 1;
        public string SKU { get; set; } = "";
    }
}

