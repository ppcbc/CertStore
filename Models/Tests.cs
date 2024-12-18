using System.ComponentModel.DataAnnotations;

namespace CertStore.Models
{
    public class Tests
    {
        [Key]
        public int TestId { get; set; }
        [Required]
        public string TestTitle { get; set; } = string.Empty;
        [Required]
        public string TestDescription { get; set; } = string.Empty;
        [Required]
        public string TestAuthor { get; set; } = string.Empty;
    }
}
