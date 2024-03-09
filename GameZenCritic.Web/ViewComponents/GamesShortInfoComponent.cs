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
        public async Task<IViewComponentResult> InvokeAsync(PaginatedList<GameShortInfoViewModel> games)
        {
            //IEnumerable<GameShortInfoViewModel> model = await gameService.AllAsync();
            //return await Task.FromResult<IViewComponentResult>(View(model));

            //int count = games.Count();

            //var paginatedGames = games.OrderBy(g=>g.ReleaseDate).Skip((StartPage - PageNext) * PageSize).Take(PageSize);

            //var model = new PaginatedList<GameShortInfoViewModel>(paginatedGames, games.Count(), StartPage, PageSize);

            //this.ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);

            //this.ViewBag.Page = 0;

            return await Task.FromResult<IViewComponentResult>(View(games));
        }
    }
}
