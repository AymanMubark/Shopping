using System;
namespace Shopping.DTOs
{
    public class ProductInformationResponseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
    }
}

