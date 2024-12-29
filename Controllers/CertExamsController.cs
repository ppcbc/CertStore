using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CertStore.Data;
using CertStore.Models;

namespace CertStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertExamsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CertExamsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CertExams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CertExam>>> GetCertExams()
        {
            return await _context.CertExams.ToListAsync();
        }

        // GET: api/CertExams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CertExam>> GetCertExam(int id)
        {
            var certExam = await _context.CertExams.FindAsync(id);

            if (certExam == null)
            {
                return NotFound();
            }

            return certExam;
        }

        // PUT: api/CertExams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCertExam(int id, CertExam certExam)
        {
            if (id != certExam.CertExamId)
            {
                return BadRequest();
            }

            _context.Entry(certExam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CertExamExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CertExams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CertExam>> PostCertExam(CertExam certExam)
        {
            _context.CertExams.Add(certExam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCertExam", new { id = certExam.CertExamId }, certExam);
        }

        // DELETE: api/CertExams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCertExam(int id)
        {
            var certExam = await _context.CertExams.FindAsync(id);
            if (certExam == null)
            {
                return NotFound();
            }

            _context.CertExams.Remove(certExam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CertExamExists(int id)
        {
            return _context.CertExams.Any(e => e.CertExamId == id);
        }
    }
}
