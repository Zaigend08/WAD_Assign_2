using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADProject.Models
{
    public class DonorModel
    {
        [Key]
        [Required]
        public int DonorId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string? Donor { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string? dAddress { get; set; }

        [Required]
        public int? dContact { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$")]
        public string? dEmail { get; set; }

        [Required]
        public int? dAge { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(8)")]
        public string? dGender { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(5)")]
        public string? dBloodType { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string? dRemarks { get; set; }

        /*public static implicit operator string(DonorModel v)
        {
            throw new NotImplementedException();
        }*/
    }
}
