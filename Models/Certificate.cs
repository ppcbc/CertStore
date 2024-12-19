using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertStore.Models;

public class Certificate
{
    [Key]
    public int CertificateId { get; set; }
    
    // [Required(ErrorMessage ="Title is required")]
    public string? Title { get; set; }
    
    [ForeignKey("CandidateId")]
    public int CandidateId { get; set; }
    
    [ForeignKey("ExamId")]
    public int ExamId { get; set; }
    
    public DateTime ScoreReportDate { get; set; }
    
    public int CandidateScore { get; set; }
}