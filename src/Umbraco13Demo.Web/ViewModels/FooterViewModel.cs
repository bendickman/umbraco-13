using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco13Demo.Web.ViewModels;

public class FooterViewModel
{
    public IEnumerable<SocialLink> SocialLinks { get; set; } = new List<SocialLink>();

    public bool HasSocialLinks => SocialLinks?.Any() ?? false;
}
