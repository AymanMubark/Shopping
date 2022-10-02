using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shopping.DTOs
{
    public class RegisterRequestDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
        [Required]
        public string UserName { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }
}
