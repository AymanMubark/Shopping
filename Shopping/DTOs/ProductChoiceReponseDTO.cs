using Shopping.Entites;

namespace Shopping.DTOs
{
    public class ProductChoiceReponseDTO
    {
        public Guid Id { get; set; }
        public double PriceIncrease { get; set; }
        public ChoiceResponseDTO Choice { get; set; }
    }
}