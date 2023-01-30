using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblTutor")]
    public class Tutor
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string TutorId { set; get; }

        [Required]
        [StringLength(50)]
        public string Status { set; get; }

        [Required]
        [StringLength(50)]
        public string TeachingMethod { set; get; }

        [Required]
        [StringLength(50)]
        public string Shedule { set; get; }

        [Required]
        [StringLength(50)]
        public string Education { set; get; }

        [Required]
        [StringLength(50)]
        public string Description { set; get; }

        [StringLength(50)]
        [ForeignKey("tblPersonalInfo")]

        public string InfoId { set; get; }
        public virtual PersonalInfo TutorInfo { set; get; }
    }
}
