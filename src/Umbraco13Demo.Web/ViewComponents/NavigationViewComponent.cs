using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco13Demo.Web.ViewModels;

namespace Umbraco13Demo.Web.ViewComponents;

public class NavigationViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(
        IPublishedContent model)
    {
        var homePage = model.AncestorOrSelf<ContentModels.Home>();
        var navItems = homePage
            ?.Children
            ?.Where(p => p.IsVisible()) ?? Enumerable.Empty<IPublishedContent>();

        var vm = new NavigationViewModel
        {
            HomePage = homePage,
            NavigationItems = navItems,
        };

        return View(vm);
    }
}
