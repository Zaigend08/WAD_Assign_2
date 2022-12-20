using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADProject.Models
{
    public class userAccountsModel
    {
        [Key]
        public int AccId { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string? AccName { get; set; }

        [Required]
        [Column(TypeName = "varchar(12)")]
        public string? userName { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
