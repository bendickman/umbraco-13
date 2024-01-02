using Microsoft.Extensions.Logging;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco13Demo.Core.Migrations.Tables;

namespace Umbraco13Demo.Core.Migrations;

public class FormSubmissionTableMigration : MigrationBase
{
    public FormSubmissionTableMigration(
        IMigrationContext context) : base(context)
    {
    }

    protected override void Migrate()
    {
        Logger.LogDebug("Running migration {MigrationStep}", "AddFormSubmissionTable");

        if (TableExists(Constants.FormSubmissionTableName) == false)
        {
            Create.Table<FormSubmission>().Do();
        }
        else
        {
            Logger.LogDebug("The database table {DbTable} already exists, skipping", Constants.FormSubmissionTableName);
        }
    }
}
