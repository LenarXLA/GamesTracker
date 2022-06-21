using System.ComponentModel.DataAnnotations;

namespace GamesTracker.Models
{
    public class GameWalkthrough
    {
        [Key]
        public Guid Id { get; set; }
        public bool Complete { get; set; }

        public Guid GameId { get; set; }      // внешний ключ
        public Game? Game { get; set; }    // навигационное свойство
    }
}
