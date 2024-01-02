using Umbraco13Demo.Core.Services;
using Umbraco13Demo.Core.Services.Interfaces;

namespace Umbraco13Demo.Web.Setup;

public static class ServicesSetup
{
    public static IUmbracoBuilder AddServices(
        this IUmbracoBuilder builder)
    {
        builder.Services.AddScoped<IFormSubmissionService, FormSubmissionService>();

        return builder;
    }
}
