using System.ComponentModel.DataAnnotations;

namespace DoAnLau_API.Models
{
    public class SignUpModel
    {
        [Required, EmailAddress]
        public string email { get; set; } = null!;
        [Required]
        public string name { get; set; }
        public string password { get; set; } = null!;
        [Required]
        public DateTime birthdate { get; set; }
        [Required]
        public bool gender { get; set; }
        [Required]
        public string comfirmPassword { get; set; } = null!;

    }
}
