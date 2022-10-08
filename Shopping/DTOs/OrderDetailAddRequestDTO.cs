using System;
using Shopping.Entites;

namespace Shopping.DTOs
{
    public class OrderDetailAddRequestDTO
    {
        public Guid ProductId { get; set; }
        public double Quantity { get; set; } = 1;
    }
}

