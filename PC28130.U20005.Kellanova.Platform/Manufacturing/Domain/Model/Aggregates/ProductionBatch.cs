using PC28130.U20005.Kellanova.Platform.Manufacturing.Model.Commands;
using PC28130.U20005.Kellanova.Platform.Manufacturing.Model.ValueObjects;
using PC28130.U20005.Kellanova.Platform.Shared.Domain.Model.ValueObjects;

namespace PC28130.U20005.Kellanova.Platform.Manufacturing.Model.Aggregates;

public partial class ProductionBatch
{
    public int Id { get; private set; }
    public BatchCode BatchReference { get; private set; }
    public PlantId FacilityId { get; private set; }
    public FreshnessWindow ShelfLifeWindow { get; private set; }
    public MonetaryAmount BatchValuation { get; private set; }
    public BatchStatus Status { get; private set; }
    public string Description { get; private set; }
    
    public ProductionBatch(int id, BatchCode batchReference, PlantId facilityId, FreshnessWindow shelfLifeWindow,
        MonetaryAmount batchValuation, BatchStatus status, string description)
    {
        Id = id;
        BatchReference = batchReference;
        FacilityId = facilityId;
        ShelfLifeWindow = shelfLifeWindow;
        BatchValuation = batchValuation;
        Status = status;
        Description = description;
    }

    public ProductionBatch(int id, Guid batchReference, Guid facilityId,
        DateOnly ProductionDate, DateOnly ExpirationDate, 
        string currency, double value, 
        int status, 
        string description) : this(id, new BatchCode(batchReference), 
        new PlantId(facilityId), new FreshnessWindow(ProductionDate, ExpirationDate),
        new MonetaryAmount(currency, value),  (BatchStatus)status, description)
    {
    }

    public ProductionBatch(CreateProductionBatchCommand command) : this(
        command.Id, command.BatchReference, command.FacilityId,
        command.ShelfLifeWindow,
        command.BatchValuation,
        command.Status, command.Description
    )
    {
        
    }

}