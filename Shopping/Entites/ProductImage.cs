using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Entites
{
    public class ProductImage
    {
        [Key]
        public Guid Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageId { get; set; }
        public Guid? ProducId { get; set; }
        public virtual Product? Product { get; set; }
    }
}

