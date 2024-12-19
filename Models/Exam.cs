using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertStore.Models;

public class Exam
{
    [Key]
    public int ExamId { get; set; }
    
    public DateTime ExaminationDate { get; set; }
    
    public int AwardedMarks { get; set; }
    
    [ForeignKey("CandidateId")]
    public int CandidateId { get; set; }
    
    [ForeignKey("CertificateId")]
    public int CertificateId { get; set; }
    
    [ForeignKey("TopicId")]
    public int TopicId { get; set; }
}