using System;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Entites
{
    public class Base
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}

