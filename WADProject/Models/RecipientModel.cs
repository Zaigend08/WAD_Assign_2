using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADProject.Models
{
    public class RecipientModel
    {
        [Key]
        public int RecipientId { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string? Recipient { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string? rAddress { get; set; }

        [Required]
        public int? rContact { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$")]
        public string? rEmail { get; set; }

        [Required]
        public int? rAge { get; set; }

        [Required]
        [Column(TypeName = "varchar(6)")]
        public string? rGender { get; set; }

        [Required]
        [Column(TypeName = "varchar(4)")]
        public string? rBloodType { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        [MinLength(6)]
        public string? rRemarks { get; set; }
    }
}
