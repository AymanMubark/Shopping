using System;
using Shopping.Entites;

namespace Shopping.DTOs
{
    public class AppUserResponseDTO
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Email { get; set; } = "";
        public virtual AddressResponseDTO? Address { get; set; }

    }
}

