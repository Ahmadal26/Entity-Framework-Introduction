using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace IntroductionToDb.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Blogs> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blogs>().HasData(
                new Blogs
                {
                    Id = 1,
                    Name = "AUK",
                    Url = "https://www.auk.edu.kw/"
                }
                );

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=asb.db");
        }
    }
}