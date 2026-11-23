using PC28130.U20005.Kellanova.Platform.Manufacturing.Model.ValueObjects;
using PC28130.U20005.Kellanova.Platform.Shared.Domain.Model.ValueObjects;

namespace PC28130.U20005.Kellanova.Platform.Manufacturing.Model.Commands;

public record CreateProductionBatchCommand(int Id , BatchCode BatchReference, PlantId FacilityId,
    FreshnessWindow ShelfLifeWindow, MonetaryAmount BatchValuation, BatchStatus Status, string Description);