namespace PC28130.U20005.Kellanova.Platform.Manufacturing.Model.ValueObjects;

public record PlantId(Guid Identifier)
{
    /// <summary>
    ///     Default constructor for the plant ID.
    /// </summary>
    public PlantId() : this(Guid.NewGuid())
    {
    }
}