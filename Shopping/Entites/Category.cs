using System;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Entites
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
    }
}

