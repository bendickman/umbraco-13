using Umbraco13Demo.Core.Migrations.Tables;

namespace Umbraco13Demo.Core.Services.Interfaces;
public interface IFormSubmissionService
{
    void Save(FormSubmission formSubmission);
}
