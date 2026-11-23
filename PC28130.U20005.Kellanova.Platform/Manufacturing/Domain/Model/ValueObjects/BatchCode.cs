namespace PC28130.U20005.Kellanova.Platform.Manufacturing.Model.ValueObjects;

public record BatchCode(Guid Identifier)
{
    /// <summary>
    ///     Default constructor for the batch code.
    /// </summary>
    public BatchCode() : this(Guid.NewGuid())
    {
    }
}