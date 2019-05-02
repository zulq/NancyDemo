using Microsoft.EntityFrameworkCore;
using NancyDemo.Models;

namespace NancyDemo.Data
{
    public class DemoDbContext : DbContext
    {
        private const string ConStr = "Host=localhost;Database=students;Username=your_username;Password=your_pwd;";

        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConStr);
        }

        public DbSet<Student> Students { get; set; }
    }
}