using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblPersonalInfo")]
    public class PersonalInfo
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string InfoId { set; get; }

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

    }
}
