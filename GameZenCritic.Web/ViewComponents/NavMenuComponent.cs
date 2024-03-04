using Microsoft.AspNetCore.Mvc;

namespace GameZenCritic.Web.ViewComponents
{
    public class NavMenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
