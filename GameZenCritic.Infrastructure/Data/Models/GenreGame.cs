using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameZenCritic.Infrastructure.Data.Models
{
    public class GenreGame
    {
        [Required]
        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        [Required]
        public Guid GameId { get; set; }
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; } = null!;
    }
}