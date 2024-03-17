using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static GameZenCritic.Core.Constants.LogicConstants;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameZenCritic.Core.Models.Contracts;

namespace GameZenCritic.Core.Models.Game
{
    public class AllGamesQueryModel : QueryModel
    {
        public override int ItemsPerPage { get; } = GamesPerPage;

        public string Genre { get; init; } = null!;

        public IEnumerable<string> Genres { get; set; } = null!;

        public IEnumerable<GameShortInfoViewModel> Games { get; set; } = new List<GameShortInfoViewModel>();
    }
}
