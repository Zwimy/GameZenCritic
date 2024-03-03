using GameZenCritic.Infrastructure.Data.Constants;
using GameZenCritic.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Models.Developer
{
    /// <summary>
    /// Short info for the developer
    /// </summary>
    public class DeveloperInfoViewModel
    {
        /// <summary>
        /// Identifying key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the company
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Rounded down reputation of the game developer for all games
        /// </summary>
        [Display(Name = "Developer reputation")]
        public int GameRep { get; set; }

        /// <summary>
        /// Link to picture of Developer logo
        /// </summary>
        public string LogoLink { get; set; } = string.Empty;

    }
}
