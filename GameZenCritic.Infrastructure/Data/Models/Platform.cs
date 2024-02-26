using GameZenCritic.Infrastructure.Data.Constants;
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
    /// Platform class inclusing identifier and name
    /// </summary>
    [Comment("Platform list inclusing identifier and name")]
    public class Platform
    {
        /// <summary>
        /// Platform identifier key
        /// </summary>
        [Comment("Platform identifier key")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Platform name
        /// </summary>
        [Comment("Platform name")]
        [Required]
        [MaxLength(DataConstants.PlatformNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property for GamesPlatforms
        /// </summary>
        public virtual ICollection<GamePlatform> GamesPlatforms { get; set; } = new List<GamePlatform>();

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}
