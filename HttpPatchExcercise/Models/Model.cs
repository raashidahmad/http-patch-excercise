using System.ComponentModel.DataAnnotations;

namespace HttpPatchExcercise.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = "N/A";
        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = "N/A";
        [Required, MaxLength(100)]
        public string Author { get; set; } = "N/A";
    }
}
