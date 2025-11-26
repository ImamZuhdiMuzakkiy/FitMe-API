using FitMe.API.Data;
using FitMe.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitMe.API.Repositories.Data;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(FitMeDbContext context) : base(context)
    {
    }

}