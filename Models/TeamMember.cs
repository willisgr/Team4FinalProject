using System.ComponentModel.DataAnnotations;

namespace Team4FinalProject.Models
{
    public class TeamMember
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
        public string CollegeProgram { get; set; } = string.Empty;
        public string YearInProgram { get; set; } = string.Empty;
    }
}