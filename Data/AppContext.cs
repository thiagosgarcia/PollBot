using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TollBot.Models;

namespace TollBot.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SQLitePCL.Batteries_V2.Init();
            optionsBuilder.UseSqlite("Data Source=scores.db");
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<User> Users { get; set; }
    }
}