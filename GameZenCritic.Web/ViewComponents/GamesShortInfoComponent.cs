using GameZenCritic.Core.Constants;
using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Extensions;
using GameZenCritic.Core.Models.Game;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static GameZenCritic.Core.Constants.LogicConstants;

namespace GameZenCritic.Web.ViewComponents
{
    public class GamesShortInfoComponent : ViewComponent
    {
        private readonly IGameService gameService;

        public GamesShortInfoComponent(IGameService _gameService)
        {
            gameService = _gameService;
        }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<GameShortInfoViewModel> games)
        {
            //IEnumerable<GameShortInfoViewModel> model = await gameService.AllAsync();
            //return await Task.FromResult<IViewComponentResult>(View(model));

            var paginatedGames = games.Skip((StartPage - PageNext) * PageSize).Take(PageSize);

            var model = new PaginatedList<GameShortInfoViewModel>(paginatedGames, games.Count(), StartPage, PageSize);

            return await Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
