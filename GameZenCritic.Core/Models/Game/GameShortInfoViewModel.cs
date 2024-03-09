using GameZenCritic.Infrastructure.Data.Constants;
using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Models.Game
{
    /// <summary>
    /// Short info regarding a game. To be used in Home view and as overview of Games
    /// </summary>
    public class GameShortInfoViewModel
    {
        /// <summary>
        /// Identifying key, unique
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the game
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Link to picture of box art for the game
        /// </summary>
        public string Picture { get; set; } = string.Empty;

        /// <summary>
        /// Average total score of reviews for the game
        /// </summary>
        [Display(Name = "Game score")]
        public decimal TotalScore { get; set; } = 0m;

        public DateTime ReleaseDate { get; set; }

    }
}
