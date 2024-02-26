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
    /// The reviews navigational entity from each player for each game
    /// </summary>
    [Comment("The reviews navigational entity from each player for each game")]
    public class PlayerGameReview
    {
        /// <summary>
        /// Review identifier and key relation
        /// </summary>
        [Comment("Review key/identifier")]
        [Required]
        public Guid ReviewId { get; set; }

        /// <summary>
        /// Foreign key and navigational property to Review
        /// </summary>
        [ForeignKey(nameof(ReviewId))]
        public Review Review { get; set; } = null!;

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
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}
