using PC28130.U20005.Kellanova.Platform.Manufacturing.Model.Aggregates;
using PC28130.U20005.Kellanova.Platform.Shared.Domain.Repositories;
using PC28130.U20005.Kellanova.Platform.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;
using PC28130.U20005.Kellanova.Platform.Shared.Infrastructure.Persistence.EntityFrameworkCore.Repositories;

namespace PC28130.U20005.Kellanova.Platform.Manufacturing.Infrastructure.Persistence.EntityFrameworkCore.Respositories;

public class ProductionBatchRepository(AppDbContext context) : BaseRepository<ProductionBatch>(context), IBaseRepository<ProductionBatch>
{
    
}