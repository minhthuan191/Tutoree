using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutoree.Models
{
    [Table("tblLocation")]
    public class Location
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string LocationId { set; get; }
        
        [Required]
        [StringLength(50)]
        public string LocationName { set; get; }


    }
}
