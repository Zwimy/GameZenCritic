using GameZenCritic.Core.Models.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Models.Developer
{
    public class DeveloperDetailsViewModel
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

        public IEnumerable<GameShortInfoViewModel> Games { get; set; } = new List<GameShortInfoViewModel>();
    }
}
