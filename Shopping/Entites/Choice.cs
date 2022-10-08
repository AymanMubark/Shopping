using System;
namespace Shopping.Entites
{
    public class Choice
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public Guid? ChoiceCategoryId { get; set; }
        public virtual ChoiceCategory? ChoiceCategory { get; set; }
    }
}

