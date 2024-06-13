using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace _5pks.models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
