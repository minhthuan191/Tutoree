using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblTutor_Student")]
    public class Tutor_Student
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string Id { set; get; }

        [Required]
        [StringLength(50)]
        [ForeignKey("tblStudent")]

        public string StudentId { set; get; }
        public virtual Student Student { set; get; }

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
