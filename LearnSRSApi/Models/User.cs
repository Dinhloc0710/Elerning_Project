using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnSRSApi.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; } 
        public string Img { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }


        public string? VerificationToken { get; set; }
        public DateTime? VerifiedAt { get; set; }

        public string? PasswordResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }


        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
