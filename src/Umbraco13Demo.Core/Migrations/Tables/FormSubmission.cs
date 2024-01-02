using NPoco;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;

namespace Umbraco13Demo.Core.Migrations.Tables;

[TableName(Constants.FormSubmissionTableName)]
[PrimaryKey("Id", AutoIncrement = true)]
[ExplicitColumns]
public class FormSubmission
{
    [PrimaryKeyColumn(AutoIncrement = true, IdentitySeed = 1)]
    [Column("Id")]
    public int Id { get; set; }

    [Column("Name")]
    public required string Name { get; set; }

    [Column("Email")]
    public required string Email { get; set; }

    [Column("Message")]
    [SpecialDbType(SpecialDbTypes.NVARCHARMAX)]
    public string Message { get; set; } = string.Empty;
}
