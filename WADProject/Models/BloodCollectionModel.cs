using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADProject.Models
{
    public class BloodCollectionModel
    {
        
        [Key]
        public int BloodColId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string? Donors { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string? bldType { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        [MinLength(10)]
        public string? Hospital { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(3)")]
        [MinLength(1)]
        public string? noOfBags { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime dateOfCollection { get; set; }
    }
}
