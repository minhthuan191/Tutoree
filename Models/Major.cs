using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{

    [Table("tblMajor")]
    public class Major
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string MajorId { set; get; }

        [Required]
        [StringLength(50)]
        public string MajorName { set; get; }


    }
}
