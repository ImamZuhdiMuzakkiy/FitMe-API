using FitMe.API.Repositories.Data;

namespace FitMe.API.Repositories.Interfaces;

public interface IRepository<Repo>
{
    Task<IEnumerable<Repo>> GetAllAsync(CancellationToken cancellationToken);
    Task<Repo?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task CreateAsync(Repo param, CancellationToken cancellationToken);
    Task UpdateAsync(Repo param);
    Task DeleteAsync(Repo param);
}
