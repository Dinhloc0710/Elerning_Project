using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnSRSApi.Models
{
    public class Result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResultId { get; set; }
        public float Score { get; set; }
        public DateTime ExamDate { get; set; }


        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
