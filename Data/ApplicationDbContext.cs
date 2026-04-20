using Microsoft.EntityFrameworkCore;
using Team4FinalProject.Models;

namespace Team4FinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Game>().HasData(
                new Game { Id = 1, Title = "RoboCop: Rogue City", Developer = "Teyon", Genre = "First Person Shooter", Price = 1.00 },
                new Game { Id = 2, Title = "Astroneer", Developer = "System Era Softworks", Genre = "Open World Survival Craft", Price = 29.99 },
                new Game { Id = 3, Title = "Dispatch", Developer = "AdHoc Studio", Genre = "Point & Click", Price = 29.99 },
                new Game { Id = 4, Title = "Cyberpunk 2077", Developer = "CD PROJEKT RED", Genre = "Open World RPG", Price = 59.99 },
                new Game { Id = 5, Title = "Warhammer 40,000: Dawn of War - Definitive Edition", Developer = "Relic Entertainment", Genre = "WAAAAGH Real Time Strategy", Price = 29.99 },
                new Game { Id = 6, Title = "Dyson Sphere Program", Developer = "Youthcat Studio", Genre = "Base Building", Price = 15.99 },
                new Game { Id = 7, Title = "Diablo II: Resurrected - Infernal Edition", Developer = "Blizzard Entertainment, Inc.", Genre = "Action RPG", Price = 39.99 }
            );
            builder.Entity<Hobby>().HasData(
                new Hobby { Id = 1, HobbyName = "3D Printing", HobbyType = "Digital", YearsPracticed = 1, IsExpensive = true },
                new Hobby { Id = 2, HobbyName = "Video Games", HobbyType = "Digital", YearsPracticed = 30, IsExpensive = true },
                new Hobby { Id = 3, HobbyName = "Reading", HobbyType = "Intellectual", YearsPracticed = 35, IsExpensive = false },
                new Hobby { Id = 4, HobbyName = "Concerts", HobbyType = "Physical", YearsPracticed = 20, IsExpensive = true },
                new Hobby { Id = 5, HobbyName = "Traveling", HobbyType = "Physical", YearsPracticed = 5, IsExpensive = true },
                new Hobby { Id = 6, HobbyName = "Hiking", HobbyType = "Physical", YearsPracticed = 1, IsExpensive = false },
                new Hobby { Id = 7, HobbyName = "Volunteering", HobbyType = "Social", YearsPracticed = 0, IsExpensive = false }
            );
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Grant Willis", Birthdate = new DateTime(2004, 10, 15), CollegeProgram = "BSIT", YearInProgram = "Junior"},
                new TeamMember { Id = 2, FullName = "Robert Mays", Birthdate = new DateTime(1985, 7, 20), CollegeProgram = "MSIT", YearInProgram = "Second"},
                new TeamMember { Id = 3, FullName = "William Boulle", Birthdate = new DateTime(1000, 1, 1), CollegeProgram = "", YearInProgram = ""}
            );
            /*
            builder.Entity<Language>().HasData(
                new Language {},
            );
            */
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}