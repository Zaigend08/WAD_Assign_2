using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADProject.Models
{
    public class BloodRequestModel
    {
        [Key]
        public int BloodReqId { get; set; }

        [Required]
        public int? controlNo { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string? requestedBy { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(15)")]
        public RecipientModel? Recipient { get; set; }

        [Required]
        public int? Amount { get; set; }

        [Required]
        [Column(TypeName = "varchar(4)")]
        public string? BloodType { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        [MinLength(1)]
        public string? noOfBags { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        [MinLength(6)]
        public string? Remarks { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string? Purpose { get; set; }

    }
}
