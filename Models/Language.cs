using System.ComponentModel.DataAnnotations;

namespace Team4FinalProject.Models
{
    // programming language
    public class Language
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        // ex: python
        public string Type { get; set; } = string.Empty;
        // ex: General purpose
        public bool IsStronglyTyped { get; set; }
        public bool IsCompiled { get; set; }
    }
}