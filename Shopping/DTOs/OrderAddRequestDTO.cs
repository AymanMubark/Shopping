using System;
using Shopping.Entites;

namespace Shopping.DTOs
{
    public class OrderAddRequestDTO
    {
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Apartment { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Region { get; set; } = "";
        public string City { get; set; } = "";
        public string Details { get; set; } = "";
        public string ZipCode { get; set; } = "";
        public string Note { get; set; } = "";
        public List<OrderDetailAddRequestDTO> OrderDetails { get; set; }
    }
}

