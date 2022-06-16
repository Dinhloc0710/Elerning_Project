using System.ComponentModel.DataAnnotations;

namespace LearnSRSApi.Models
{
    public class ResetPassword
    {
        [Required]
        public string Token { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Vui lòng nhập ít nhất 6 ký tự ")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
