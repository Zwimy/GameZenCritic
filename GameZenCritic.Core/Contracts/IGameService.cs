using GameZenCritic.Core.Models.Game;
using GameZenCritic.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Contracts
{
    public interface IGameService
    {
        Task<IEnumerable<GameShortInfoViewModel>> AllAsync();
        Task<IEnumerable<GameShortInfoViewModel>> ByDevIdAsync(int id);
        Task<TopGamesAndDevelopersViewModel> TopGamesInfoAsync();
    }
}
