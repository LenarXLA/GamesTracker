using System.ComponentModel.DataAnnotations;

namespace GamesTracker.Models
{
    public class Game
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public byte[]? Poster { get; set; }

        public List<GameWalkthrough> GameWalkthroughs { get; set; } = new();
        public List<GameRecent> GameRecents { get; set; } = new();
    }
}
