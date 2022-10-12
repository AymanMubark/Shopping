namespace Shopping.Entites
{
    public class Address: Base
    {
        public string Region { get; set; } = "";
        public string City { get; set; } = "";
        public string Details { get; set; } = "";
        public Guid? AppUserId { get; set; } = null!;
        public virtual AppUser AppUser { get; set; } = null!;
    }
}