using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elerning_Project.Models
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ExamId { get; set; }
        public string ExamName { get; set; }
        public DateTime ExamDate { get; set; }
        public float Time { get; set; }
        public string DVT { get; set; }
        public bool Status { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int TypeExamId { get; set; }
        public TypeExam TypeExam { get; set; }
    }
}
