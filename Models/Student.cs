using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblStudent")]
    public class Student
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string StudentId { set; get; }

        [Required]
        [StringLength(50)]
        public string Email { set; get; }

        [Required]
        [StringLength(50)]
        public string Password { set; get; }

        [StringLength(50)]
        public string Name { set; get; }

        public int Age { set; get; }

        [StringLength(10)]
        public string Phone { set; get; }

        [Required]
        public int Year { set; get; }

        [Required]
        [StringLength(50)]
        public string Semester{ set; get; }

        [Required]
        [ForeignKey("tblLocation")]

        public string LocationId { set; get; }
        public virtual Location Location { set; get; }

        [Required]
        [StringLength(50)]
        [ForeignKey("tblMajor")]

        public string MajorId { set; get; }
        public virtual Major Major { set; get; }

    }
}
