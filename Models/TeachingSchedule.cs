using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblTeachingSchedule")]
    public class TeachingSchedule
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string TeachingScheduleId { set; get; }

        [Required]
        [StringLength(50)]
        public string Day { set; get; }

        [Required]
        [StringLength(50)]
        public string TimeRange { set; get; }

    }
}
