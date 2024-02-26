using GameZenCritic.Infrastructure.Data.Constants;
using Microsoft.AspNetCore.Identity;
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
    /// The reviews from each player for each game including score and details
    /// </summary>
    [Comment("The reviews from each player for each game including score and details")]
    public class PlayerGameReview
    {
        /// <summary>
        /// Player identifier and key relation
        /// </summary>
        [Comment("Player key/identifier")]
        [Required]
        public string PlayerId { get; set; } = string.Empty;

        /// <summary>
        /// Foreign key and navigational property to Player
        /// </summary>
        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; } = null!;

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
        /// Text info for the review
        /// </summary>
        [Comment("Text info for the review")]
        [Required]
        [StringLength(DataConstants.ReviewDescriptionMaxLength)]
        public string Details { get; set; } = string.Empty;

        /// <summary>
        /// The score for the game on this review 0-10
        /// </summary>
        [Comment("The score for the game on this review 0-10")]
        [Required]
        [Range(DataConstants.ReviewScoreMinValue,DataConstants.ReviewScoreMaxValue)]
        public int Score { get; set; }

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}
