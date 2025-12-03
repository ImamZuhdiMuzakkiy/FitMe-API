using FitMe.API.Data;
using FitMe.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitMe.API.Repositories.Data;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(FitMeDbContext context) : base(context)
    {
    }

    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken)
    {
        return await _context.Users
        .Include(x => x.Role)
        .FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }

}