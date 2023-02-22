using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblSubject")]
    public class Subject
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string SubjectId { set; get; }

        [Required]
        [StringLength(50)]
        public string SubjectName { set; get; }


        [Required]
        [StringLength(500)]
        public string Description { set; get; }

        [StringLength(50)]
        [ForeignKey("tblMajor")]

        public string MajorId { set; get; }
        public virtual Major Major { set; get; }
    }
}
