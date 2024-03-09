using GameZenCritic.Core.Contracts;
using GameZenCritic.Core.Models.Game;
using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.ViewComponents
{
    public class GamesShortInfoComponent : ViewComponent
    {
        private readonly IGameService gameService;

        public GamesShortInfoComponent(IGameService _gameService)
        {
            gameService = _gameService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<GameShortInfoViewModel> model = await gameService.AllAsync();
            return await Task.FromResult<IViewComponentResult>(View(model));
        }

        /// <summary>
        /// games by specific developer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            IEnumerable<GameShortInfoViewModel> model = await gameService.ByDevIdAsync(id);
            return await Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
