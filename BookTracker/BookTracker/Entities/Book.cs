using System.ComponentModel.DataAnnotations;

namespace BookTracker.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [MaxLength(50)]
        public required string Author { get; set; }
        public DateTime DateAdded { get; set; }
        
    }
}
