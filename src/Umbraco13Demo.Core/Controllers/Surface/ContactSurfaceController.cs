using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.Filters;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco13Demo.Core.Migrations.Tables;
using Umbraco13Demo.Core.Models.ViewModels;
using Umbraco13Demo.Core.Services.Interfaces;

namespace Umbraco13Demo.Core.Controllers.Surface;
public class ContactSurfaceController : SurfaceController
{
    private readonly IFormSubmissionService _formSubmissionService;

    public ContactSurfaceController(
        IUmbracoContextAccessor umbracoContextAccessor,
        IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services,
        AppCaches appCaches,
        IProfilingLogger profilingLogger,
        IPublishedUrlProvider publishedUrlProvider,
        IFormSubmissionService formSubmissionService)
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _formSubmissionService = formSubmissionService;
    }

    [HttpPost]
    [ValidateUmbracoFormRouteString]
    public IActionResult HandleSubmit(
        ContactFormViewModel model)
    {
        // validation removed for brevity

        var formSubmission = new FormSubmission
        {
            Name = model.Name,
            Email = model.Email,
            Message = model.Message,
        };

        _formSubmissionService.Save(formSubmission);

        return RedirectToCurrentUmbracoPage();
    }
}
