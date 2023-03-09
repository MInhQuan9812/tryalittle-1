using System.ComponentModel.DataAnnotations;

namespace testdocnet.Models
{
    public class SignInModel
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
