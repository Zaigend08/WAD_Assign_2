using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADProject.Models
{
    public class BloodIssuedModel
    {

        [Key]
        [Required]
        public int BloodIsudId { get; set; }

        [Required]
        public int? controlNo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime dateOfIssuance { get; set; }

        [Required]
        public int? amountPaid { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string? issuedBY { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string? issuedTo { get; set; }

    }
}
