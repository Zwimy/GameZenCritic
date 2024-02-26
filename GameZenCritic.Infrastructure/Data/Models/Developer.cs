using GameZenCritic.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GameZenCritic.Infrastructure.Data.Models
{
    /// <summary>
    /// The developer company of the game
    /// </summary>
    [Comment("The developer company of the game")]
    public class Developer
    {
        /// <summary>
        /// Identifying key
        /// </summary>
        [Comment("Identifying key")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the company
        /// </summary>
        [Comment("Name of the company")]
        [Required]
        [StringLength(DataConstants.DeveloperNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Rounded down reputation of the game developer for all games
        /// </summary>
        [Comment("Rounded down reputation of the game developer for all games")]
        [Range(DataConstants.ReviewScoreMinValue, DataConstants.ReviewScoreMaxValue)]
        public int GameRep { get; set; }

        /// <summary>
        /// Navigational property to Game class
        /// </summary>
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}