using System.ComponentModel.DataAnnotations;

namespace CertStore.Models
{
    public class UserStaf
    {
        [Key]
        public int UserStafId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int CertExamId { get; set; } = 0;
        public DateTime DateOfSelectCertExam { get; set; } = DateTime.UtcNow;
        public DateTime DateOfBuyCertExam { get; set; } = DateTime.MinValue;
        public bool HasBought { get; set; } = false;
        public int UserDetailsId { get; set; } = 0;
        public bool Redeem { get; set; }
        public DateTime DateOfSendCertExam { get; set; } = DateTime.MinValue;
    }
}
