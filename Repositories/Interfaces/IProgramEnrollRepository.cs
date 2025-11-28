namespace FitMe.API.Repositories.Interfaces;

public interface IProgramEnrollRepository : IRepository<ProgramEnroll>
{
    Task<IEnumerable<ProgramEnroll>> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken);
}
