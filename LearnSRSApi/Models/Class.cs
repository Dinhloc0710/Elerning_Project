using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnSRSApi.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public string Link { get; set; }
        public string PassClass { get; set; }
        public bool Status { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
