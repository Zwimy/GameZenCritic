using GameZenCritic.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Models
{
    public class Review
    {
        /// <summary>
        /// Game identifier and key relation
        /// </summary>
        [Comment("Review key/identifier")]
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Text info for the review
        /// </summary>
        [Comment("Text info for the review")]
        [Required]
        [StringLength(DataConstants.ReviewDescriptionMaxLength)]
        public string Details { get; set; } = string.Empty;

        /// <summary>
        /// The score on this review 0-10
        /// </summary>
        [Comment("The score on this review 0-10")]
        [Required]
        [Range(DataConstants.ReviewScoreMinValue, DataConstants.ReviewScoreMaxValue)]
        public int Score { get; set; }

        /// <summary>
        /// When the review is written
        /// </summary>
        [Comment("When the review is written")]
        [Required]
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// Navigational property to PlayersGamesReviews
        /// </summary>
        public virtual ICollection<PlayerGameReview> PlayersGamesReviews { get; set; } = new List<PlayerGameReview>();

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}
