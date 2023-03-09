using System.ComponentModel.DataAnnotations;

namespace testdocnet.Models
{
    public class SignUpModel
    {
        [Required,EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set;} = null!;
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set;} = null!;
        [Required]
        public string ConfirmPassword { get; set; } = null!;
        
    }
}
