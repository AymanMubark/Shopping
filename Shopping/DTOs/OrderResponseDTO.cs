using System;
using Shopping.Entites;
using Shopping.Entites.Enums;

namespace Shopping.DTOs
{
    public class OrderResponseDTO
    {
        public Guid Id { get; set; }
        public string OrderId { get; set; } = "";
        public DateTime CreatedDate { get; set; } 
        public string Status { get; set; } 
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public double Total { get; set; } = 0;
        public double Tax { get; set; } = 0;
        public string Region { get; set; } = "";
        public string City { get; set; } = "";
        public string Details { get; set; } = "";
        public string ZipCode { get; set; } = "";
        public string Note { get; set; } = "";
        public ICollection<OrderDetailResponseDTO> OrderDetails { get; set; } = null!;
    }
}

