using System;
using Shopping.Entites;

namespace Shopping.DTOs
{
    public class ChoiceResponseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public virtual ChoiceCategoryResponseDTO? ChoiceCategory { get; set; }
    }
}

