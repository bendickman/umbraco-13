using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco13Demo.Web.ViewModels;

namespace Umbraco13Demo.Web.ViewComponents;

public class FooterViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(
        IPublishedContent model)
    {
        var root = model.Root();

        var globalSettings = root
            ?.Siblings<ContentModels.GlobalSettings>()
            ?.FirstOrDefault();

        var vm = new FooterViewModel
        {
            SocialLinks = globalSettings.SocialLinks,
        };

        return View(vm);
    }
}
