using System.Runtime.InteropServices.JavaScript;

namespace PC28130.U20005.Kellanova.Platform.Manufacturing.Model.ValueObjects;

public record FreshnessWindow(DateOnly ProductionDate ,DateOnly ExpirationDate);