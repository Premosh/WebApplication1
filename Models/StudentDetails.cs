using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class StudentDetails
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; } = string.Empty;
    }
}
