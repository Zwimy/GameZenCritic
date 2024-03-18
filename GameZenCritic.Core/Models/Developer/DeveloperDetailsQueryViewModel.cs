using GameZenCritic.Core.Models.Contracts;
using GameZenCritic.Core.Models.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameZenCritic.Core.Constants.LogicConstants;


namespace GameZenCritic.Core.Models.Developer
{
    public class DeveloperDetailsQueryViewModel : QueryModel
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
        [Display(Name = "Logo")]
        public string LogoLink { get; set; } = string.Empty;

        public override int ItemsPerPage { get; } = PageSize;

        public IEnumerable<GameShortInfoViewModel> Games { get; set; } = new List<GameShortInfoViewModel>();
    }
}
