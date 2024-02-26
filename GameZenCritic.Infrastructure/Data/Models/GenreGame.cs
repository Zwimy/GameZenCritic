using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameZenCritic.Infrastructure.Data.Models
{
    /// <summary>
    /// List of the games and genres, many to many related
    /// </summary>
    [Comment("List of the games and genres, many to many related")]
    public class GenreGame
    {
        /// <summary>
        /// Genre identifier and key relation
        /// </summary>
        [Comment("Genre key/identifier")]
        [Required]
        public int GenreId { get; set; }

        /// <summary>
        /// Foreign key and navigational property to Genre
        /// </summary>
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        /// <summary>
        /// Game identifier and key relation
        /// </summary>
        [Comment("Game key/identifier")]
        [Required]
        public Guid GameId { get; set; }

        /// <summary>
        /// Foreign key and navigational property to Game
        /// </summary>
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; } = null!;

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}