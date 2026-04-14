using System.ComponentModel.DataAnnotations;

namespace Team4FinalProject.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        public string Developer { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public double Price { get; set; } 
    }
}