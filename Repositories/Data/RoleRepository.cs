using FitMe.API.Data;
using FitMe.API.Repositories.Interfaces;

namespace FitMe.API.Repositories.Data;

public class RoleRepository : Repository<Role>, IRoleRepository
{
    public RoleRepository(FitMeDbContext context) : base(context)
    {
    }

}
