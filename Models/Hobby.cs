using System.ComponentModel.DataAnnotations;

namespace Team4FinalProject.Models
{
    public class Hobby
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string HobbyName { get; set; } = string.Empty;
        public string HobbyType { get; set; } = string.Empty;
        public int YearsPracticed { get; set; }
        public bool IsExpensive { get; set; }
    }
}