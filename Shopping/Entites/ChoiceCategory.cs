using System;
namespace Shopping.Entites
{
    public class ChoiceCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public virtual List<Choice> Choices { get; set; } = null!;
    }
}

