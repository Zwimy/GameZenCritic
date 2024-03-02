using GameZenCritic.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Models
{
    /// <summary>
    /// Game class including description and various info
    /// </summary>
    [Comment("Game list including description and various info")]
    public class Game
    {
        /// <summary>
        /// Identifying key, unique
        /// </summary>
        [Comment("Identifying key")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the game
        /// </summary>
        [Comment("Name of the game")]
        [Required]
        [MaxLength(DataConstants.GameNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Detailed info of the game
        /// </summary>
        [Comment("Detailed info of the game")]
        [Required]
        [MaxLength(DataConstants.GameDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Link to picture of box art for the game
        /// </summary>
        [Comment("Link to picture of box art for the game")]
        [MaxLength(DataConstants.GamePictureMaxLength)]
        public string Picture { get; set; } = string.Empty;

        /// <summary>
        /// Date of the game initial release
        /// </summary>
        [Comment("Date of the game initial release")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Rating for recommended age (usually by ESRB)
        /// </summary>
        [Comment("Rating for recommended age (usually by ESRB)")]
        [Required]
        [MaxLength(DataConstants.GameAgeRatingMaxLength)]
        public string AgeRating { get; set; } = string.Empty;

        /// <summary>
        /// Link to picture of age rating for the game
        /// </summary>
        [Comment("Link to picture of age rating for the game")]
        [MaxLength(DataConstants.GameAgeRatingPictureMaxLength)]
        public string AgeRatingPicture { get; set; } = string.Empty;

        /// <summary>
        /// Average total score of reviews for the game
        /// </summary>
        [Comment("Average total score of reviews for the game")]
        [Required]
        [Range(typeof(decimal), DataConstants.GameTotalScoreMinValue, DataConstants.GameTotalScoreMaxValue)]
        [Column(TypeName = DataConstants.GameTotalScoreDbFormat)]
        public decimal TotalScore { get; set; } = 0m;

        /// <summary>
        /// The game developer identifier
        /// </summary>
        [Comment("The game developer identifier")]
        [Required]
        public int DeveloperId { get; set; }

        /// <summary>
        /// Foreign key and navigational property to Developer
        /// </summary>
        [ForeignKey(nameof(DeveloperId))]
        public Developer Developer { get; set; } = null!;

        /// <summary>
        /// The game publisher identifier
        /// </summary>
        [Comment("The game publisher identifier")]
        [Required]
        public int PublisherId { get; set; }

        /// <summary>
        /// Foreign key and navigational property to Publisher
        /// </summary>
        [ForeignKey(nameof(PublisherId))]
        public Publisher Publisher { get; set; } = null!;

        /// <summary>
        /// The game genre identifier
        /// </summary>
        [Required]
        [Comment("The game genre identifier")]
        public int GenreId { get; set; }

        /// <summary>
        /// Navigational property to Genre
        /// </summary>
        [ForeignKey(nameof(GenreId))]
        public virtual Genre Genre { get; set; } = null!;

        /// <summary>
        /// Navigational property and collection to News
        /// </summary>
        public virtual ICollection<News> News { get; set; } = new List<News>();

        /// <summary>
        /// Navigational property and collection to GamesPlatforms
        /// </summary>
        public virtual ICollection<GamePlatform> GamesPlatforms { get; set; } = new List<GamePlatform>();

        /// <summary>
        /// Navigational property and collection to PlayersGamesReviews
        /// </summary>
        public virtual ICollection<PlayerGameReview> PlayersGamesReviews { get; set; } = new List<PlayerGameReview>();

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}
