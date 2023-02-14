using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    public enum TutorStatus
    {
        ACTIVE = 1,
        INACTIVE = 0
    }

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
        [Required]
        [StringLength(10)]
        public string Phone { set; get; } 

        [Required]
        public TutorStatus Status { set; get; }

        [Required]
        [StringLength(50)]
        public string TeachingMethod { set; get; }


        [Required]
        [StringLength(50)]
        public string Education { set; get; }

        [Required]
        [StringLength(100)]
        public string Description { set; get; }


        [StringLength(50)]
        [ForeignKey("tblTeachingSchedule")]
        
        public string TeachingScheduleId { set; get; }

        public virtual TeachingSchedule TeachingSchedule { get; set; }
    }
}
