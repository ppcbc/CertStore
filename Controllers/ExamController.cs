using CertStore.Data;
using CertStore.DTOs;
using CertStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CertStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ExamController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("categories-with-exams")]
        public async Task<IActionResult> GetCategoriesWithExams()
        {
            var categories = await _context.ExamCategories
                .Include(c => c.Exams)
                .ToListAsync();

            return Ok(categories);
        }


        [HttpPost("create-exam")]
        public async Task<IActionResult> CreateExam([FromBody] ExamDto examDto)
        {
            // Validate if CategoryId exists
            if (!_context.ExamCategories.Any(c => c.Id == examDto.CategoryId))
            {
                return BadRequest(new { message = "Invalid CategoryId. Category does not exist." });
            }

            // Map DTO to Model
            var exam = new Exam
            {
                ExamName = examDto.ExamName,
                CategoryId = examDto.CategoryId,
                QuestionText = examDto.QuestionText,
                QuestionPhotoLink = examDto.QuestionPhotoLink,
                Option1 = examDto.Option1,
                IsCorrect1 = examDto.IsCorrect1,
                Option2 = examDto.Option2,
                IsCorrect2 = examDto.IsCorrect2,
                Option3 = examDto.Option3,
                IsCorrect3 = examDto.IsCorrect3,
                Option4 = examDto.Option4,
                IsCorrect4 = examDto.IsCorrect4
            };

            _context.Exams.Add(exam);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Exam created successfully." });
        }

        [HttpGet("exams-by-category/{categoryId}")]
        public async Task<IActionResult> GetExamsByCategory(int categoryId)
        {
            var exams = await _context.Exams
                .Include(e => e.Category) // Ensure Category is loaded
                .Where(e => e.CategoryId == categoryId)
                .ToListAsync();

            if (!exams.Any())
            {
                return NotFound(new { message = "No exams found for this category." });
            }

            return Ok(exams);
        }

        [HttpDelete("delete-exam/{id}")]
        public async Task<IActionResult> DeleteExam(int id)
        {
            // Find the exam by ID
            var exam = await _context.Exams.FindAsync(id);

            if (exam == null)
            {
                return NotFound(new { message = "Exam not found." });
            }

            // Remove the exam from the database
            _context.Exams.Remove(exam);

            try
            {
                await _context.SaveChangesAsync();
                return Ok(new { message = "Exam deleted successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the exam.", error = ex.Message });
            }
        }




    }
}
