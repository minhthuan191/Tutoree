using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblTeaching")]
    public class Teaching
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string TeachingId { set; get; }

        [Required]
        [StringLength(50)]
        [ForeignKey("tblSubject")]

        public string SubjectId { set; get; }
        public virtual Subject Subject { set; get; }

        [Required]
        [StringLength(50)]
        [ForeignKey("tblTutor")]

        public string TutorId { set; get; }
        public virtual Tutor Tutor { set; get; }

        [Required]
        [StringLength(50)]
        public string Status { set; get; }
    }
}
