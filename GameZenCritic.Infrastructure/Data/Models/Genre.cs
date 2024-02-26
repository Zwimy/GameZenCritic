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
    /// The genre of the game e.g. Action, Adventure etc.
    /// </summary>
    [Comment("The genre of the game e.g. Action, Adventure etc.")]
    public class Genre
    {
        /// <summary>
        /// Identifying key
        /// </summary>
        [Comment("Identifying key")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Genre
        /// </summary>
        [Comment("Name of the Genre")]
        [Required]
        [StringLength(DataConstants.GenreNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property collection to Games
        /// </summary>
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();

        /// <summary>
        /// Deletion flag
        /// </summary>
        [Comment("Deletion flag")]
        public bool IsDeleted { get; set; } = false;
    }
}
