using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class SignInModel
    {
       
        [Required,EmailAddress]
        public string email { get; set; } = null!;
        [Required]
        public string password { get; set; } = null!;
    }
}
