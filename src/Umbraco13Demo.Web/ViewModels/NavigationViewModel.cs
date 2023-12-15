using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco13Demo.Web.ViewModels;

public class NavigationViewModel
{
    public ContentModels.Home HomePage { get; set; }

    public IEnumerable<IPublishedContent> NavigationItems { get; set; } = Enumerable.Empty<IPublishedContent>();
}
