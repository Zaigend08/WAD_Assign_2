using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADProject.Models
{
    public class RecipientModel
    {
        [Key]
        public int RecipientId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string? Recipient { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string? rAddress { get; set; }

        [Required]
        public int? rContact { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$")]
        public string? rEmail { get; set; }

        [Required]
        public int? rAge { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string? rGender { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(4)")]
        public string? rBloodType { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MinLength(6)]
        public string? rRemarks { get; set; }
    }
}
