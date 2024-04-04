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
        public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();

    }

    public class Chapter
    {
        [Required]
        public int ChapterId { get; set; }
        public string ChapterName { get; set; } = "-";
    }
}
