using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Infrastructure.Data.Models
{
    /// <summary>
    /// Game object including description and various info
    /// </summary>
    [Comment("Game list including description and various info")]
    public class Game
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(180)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Picture { get; set; } = string.Empty;

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string AgeRating { get; set; } = string.Empty;

        [MaxLength(500)]
        public string AgeRatingPicture { get; set; } = string.Empty;

        public virtual ICollection<GamePlatform> GamesPlatforms { get; set; } = new List<GamePlatform>();




    }
}
