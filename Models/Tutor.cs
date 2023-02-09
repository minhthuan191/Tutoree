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
        public string Email { set; get; }

        [Required]
        [StringLength(50)]
        public string Password { set; get; }

        [StringLength(50)]
        public string Name { set; get; }

        [StringLength(10)]
        public string Phone { set; get; } 

        [Required]
        [StringLength(50)]
        public string Status { set; get; }

        [Required]
        [StringLength(50)]
        public string TeachingMethod { set; get; }


        [Required]
        [StringLength(50)]
        public string Education { set; get; }

        [Required]
        [StringLength(50)]
        public string Description { set; get; }


        [Required]
        [StringLength(50)]
        [ForeignKey("tblTeachingSchedule")]
        
        public string TeachingScheduleId { set; get; }

        public virtual TeachingSchedule TeachingSchedule { get; set; }
    }
}
