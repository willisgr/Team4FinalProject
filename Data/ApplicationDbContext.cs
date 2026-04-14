using Microsoft.EntityFrameworkCore;
using Team4FinalProject.Models;

namespace Team4FinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}