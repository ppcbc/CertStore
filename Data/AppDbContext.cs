using CertStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CertStore.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tests> Tests { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
