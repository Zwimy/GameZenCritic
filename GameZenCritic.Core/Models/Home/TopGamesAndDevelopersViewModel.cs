using GameZenCritic.Core.Models.Developer;
using GameZenCritic.Core.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Models.Home
{
    /// <summary>
    /// View model to be used on main page with top 3 games and current Developer with highest rating
    /// </summary>
    public class TopGamesAndDevelopersViewModel
    {
        public IEnumerable<GameShortInfoViewModel> Games { get; set; } = new List<GameShortInfoViewModel>();

        public DeveloperInfoViewModel TopDeveloper { get; set; } = null!;

    }
}
