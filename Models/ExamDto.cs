using System.ComponentModel.DataAnnotations;

namespace CertStore.DTOs
{
    public class ExamDto
    {
        [Required]
        public string ExamName { get; set; }
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public string QuestionText { get; set; } = string.Empty;
        public string QuestionPhotoLink { get; set; } = string.Empty;

        public string Option1 { get; set; }
        public bool IsCorrect1 { get; set; }

        public string Option2 { get; set; }
        public bool IsCorrect2 { get; set; }

        public string Option3 { get; set; }
        public bool IsCorrect3 { get; set; }

        public string Option4 { get; set; }
        public bool IsCorrect4 { get; set; }
    }
}
