using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblSchoolYear")]
    public class SchoolYear
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string SchoolYearId { set; get; }
        
        [Required]
        [StringLength(50)]
        public string SchoolYearName { set; get; }
    }
}
