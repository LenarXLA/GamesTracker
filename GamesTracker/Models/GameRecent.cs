using System.ComponentModel.DataAnnotations;

namespace GamesTracker.Models
{
    public class GameRecent
    {
        [Key]
        public Guid Id { get; set; }
        public bool Recent { get; set; }

        public Guid GameId { get; set; }      // внешний ключ
        public Game? Game { get; set; }    // навигационное свойство
    }
}
