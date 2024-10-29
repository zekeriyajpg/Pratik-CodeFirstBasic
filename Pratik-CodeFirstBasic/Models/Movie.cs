using System.ComponentModel.DataAnnotations;

namespace Pratik_CodeFirstBasic.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        [Required]
        public int ReleaseYear { get; set; }
    }
}
