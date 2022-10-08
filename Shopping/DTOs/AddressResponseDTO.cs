using System;
using Shopping.Entites;

namespace Shopping.DTOs
{
    public class AddressResponseDTO
    {
        public Guid Id { get; set; }
        public string Region { get; set; } = "";
        public string City { get; set; } = "";
        public string Details { get; set; } = "";
    }
}

