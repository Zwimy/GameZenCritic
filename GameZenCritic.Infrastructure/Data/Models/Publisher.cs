using GameZenCritic.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GameZenCritic.Infrastructure.Data.Models
{
    /// <summary>
    /// The publisher company of the game. Publishers distribute the game.
    /// </summary>
    [Comment("The publisher company of the game")]
    public class Publisher
    {
        /// <summary>
        /// Publisher identifier key
        /// </summary>
        [Comment("Publisher identifier key")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the publisher company
        /// </summary>
        [Comment("Name of the publisher company")]
        [Required]
        [StringLength(DataConstants.PublisherNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Country of the publisher company
        /// </summary>
        [Comment("Name of the publisher company")]
        [Required]
        [StringLength(DataConstants.PublisherCountryMaxLength)]
        public string CountryLocation { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property collection for Game
        /// </summary>
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}