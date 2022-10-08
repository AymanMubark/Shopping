using System;
namespace Shopping.DTOs
{
    public class ChoiceCategoryResponseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public List<ProductChoiceReponseDTO> Choices { get; set; }
    }
}

