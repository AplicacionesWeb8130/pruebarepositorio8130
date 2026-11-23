using PC28130.U20005.Kellanova.Platform.Shared.Domain.Model.Entities;

namespace PC28130.U20005.Kellanova.Platform.Manufacturing.Model.Aggregates;

public partial class ProductionBatch : IAuditableEntity
{
    public DateTimeOffset? CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}