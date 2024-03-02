using GameZenCritic.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
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
    /// News class including title and description for a game
    /// </summary>
    [Comment("News list including title and description for a game")]
    public class News
    {
        /// <summary>
        /// Identifying key
        /// </summary>
        [Comment("Identifying key")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Game identifier and key relation
        /// </summary>
        [Comment("Game key/identifier")]
        [Required]
        public int GameId { get; set; }

        /// <summary>
        /// Foreign key and navigational property to Game
        /// </summary>
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; } = null!;

        /// <summary>
        /// Title for the news article
        /// </summary>
        [Comment("Title for the news article")]
        [Required]
        [StringLength(DataConstants.NewsTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Text description for the news article
        /// </summary>
        [Comment("Text description for the news article")]
        [Required]
        [StringLength(DataConstants.NewsDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// When the article  is published
        /// </summary>
        [Comment("When the article  is published")]
        [Required]
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}