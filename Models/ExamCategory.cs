using System.Collections;

namespace CertStore.Models
{
    public class ExamCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
