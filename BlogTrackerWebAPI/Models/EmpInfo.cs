using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlogTrackerWebAPI.Models
{
    [Table("EmpInfo")]
    public class EmpInfo
    {
        [Key]
        [Required(ErrorMessage = "The Email field is required.")]
        public string? EmailId { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string? Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        [Required(ErrorMessage = "The PassCode field is required.")]
        public int PassCode { get; set; }
    }
}