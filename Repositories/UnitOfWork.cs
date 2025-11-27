using FitMe.API.Data;

namespace FitMe.API.Repositories;

public interface IUnitOfWork
{
    Task CommitTransactionAsync(Func<Task> action, CancellationToken cancellationToken);
}

public class UnitOfWork : IUnitOfWork
{
    private readonly FitMeDbContext _context;

    public UnitOfWork(FitMeDbContext context)
    {
        _context = context;
    }

    public async Task CommitTransactionAsync(Func<Task> action, CancellationToken cancellationToken)
    {
        await using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

        try
        {
            await action();
            await _context.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);
        }
        catch 
        {
            await transaction.RollbackAsync(cancellationToken);
            throw; 
        }
    }

    public Task ClearTracksAsync(CancellationToken cancellationToken)
    {
        _context.ChangeTracker.Clear();
        return Task.CompletedTask;
    }
}
