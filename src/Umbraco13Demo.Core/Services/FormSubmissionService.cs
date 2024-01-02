using Umbraco.Cms.Infrastructure.Scoping;
using Umbraco13Demo.Core.Migrations.Tables;
using Umbraco13Demo.Core.Services.Interfaces;

namespace Umbraco13Demo.Core.Services;
public class FormSubmissionService : IFormSubmissionService
{
    private readonly IScopeProvider _scopeProvider;

    public FormSubmissionService(
        IScopeProvider scopeProvider)
    {
        _scopeProvider = scopeProvider;
    }

    public void Save(
        FormSubmission formSubmission)
    {
        if (formSubmission is null)
        {
            return;
        }

        using (var scope = _scopeProvider.CreateScope())
        {
            scope.Database.Insert(formSubmission);
            scope.Complete();
        }
    }
}
