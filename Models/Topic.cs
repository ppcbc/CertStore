using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CertStore.Models;

public class Topic
{
    [Key]
    public int TopicId { get; set; }
    
    [ForeignKey("ExamId")]
    public int ExamId { get; set; }
    
    public string? TopicDescription { get; set; }
}