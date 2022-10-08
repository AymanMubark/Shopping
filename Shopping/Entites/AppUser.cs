using Microsoft.AspNetCore.Identity;

namespace Shopping.Entites
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Address Address { get; set; }
    }
}
