using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnSRSApi.Models
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string DocumentId { get; set; }
        public string Link { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
