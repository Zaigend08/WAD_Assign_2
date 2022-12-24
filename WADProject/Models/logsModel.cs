using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADProject.Models
{
    public class logsModel
    {
        [Key]
        public int logId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string? AccName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string? date { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(12)")]
        [DataType(DataType.Time)]
        public string? loginTime { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(12)")]
        [DataType(DataType.Time)]
        public string? logoutTime { get; set; }
    }
}
