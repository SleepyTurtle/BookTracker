using System.ComponentModel.DataAnnotations;

namespace BookTracker.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; } = string.Empty;
        [MaxLength(500)]
        public string? Description { get; set; }
        [MaxLength(50)]
        public string Author { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        
    }
}
