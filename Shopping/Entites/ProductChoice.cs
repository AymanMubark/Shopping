using System;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Entites
{
    public class ProductChoice
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public double PriceIncrease { get; set; } = 0;
        public virtual Product Product { get; set; } = null!;
        public Guid? ChoiceId { get; set; }
        public virtual Choice Choice { get; set; } = null!;
    }
}