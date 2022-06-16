using System.ComponentModel.DataAnnotations;

namespace LearnSRSApi.Models
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Vui lòng nhập tối thiểu 6 ký tự!!!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public int RoleId { get; set; }
    }
}
