using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class EmailStatistic
    {
        [Key]
        public int Id { get; set; }
        public int ToUserId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? ToUserEmail { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? Subject { get; set; }
        public DateTime Time { get; set; }
        public Participant Participant { get; set; }
    }
}
