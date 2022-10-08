using System;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Entites
{
    public class ProductInformation
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public Guid? ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}

