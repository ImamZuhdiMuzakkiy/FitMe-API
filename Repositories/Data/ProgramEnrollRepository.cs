using FitMe.API.Data;
using FitMe.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitMe.API.Repositories.Data;

public class ProgramEnrollRepository : Repository<ProgramEnroll>, IProgramEnrollRepository
{
    public ProgramEnrollRepository(FitMeDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<ProgramEnroll>> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        return await _context.ProgramEnrolls
            .Where(e => e.UserId == userId)
            .ToListAsync(cancellationToken);
    }
}
