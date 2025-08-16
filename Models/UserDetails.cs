using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserDetails
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;
    }
}
