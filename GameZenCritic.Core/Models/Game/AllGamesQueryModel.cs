using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZenCritic.Core.Models.Game
{
    public class AllGamesQueryModel
    {
        public int GamesPerPage { get; } = 3;

        public string Genre { get; init; } = null!;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; } = null!;

        public int Page { get; set; } = 1;
        public int TotalPages { get; set; }

        public int TotalGamesCount { get; set; }

        public IEnumerable<string> Genres { get; set; } = null!;

        public IEnumerable<GameShortInfoViewModel> Games { get; set; } = new List<GameShortInfoViewModel>();
    }
}
