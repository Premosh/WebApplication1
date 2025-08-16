using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class StudentDetails
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
    }
}
