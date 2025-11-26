using FitMe.API.Data;
using FitMe.API.Repositories.Interfaces;

namespace FitMe.API.Repositories.Data;

public class ProgramEnrollRepository : Repository<ProgramEnroll>, IProgramEnrollRepository
{
    public ProgramEnrollRepository(FitMeDbContext context) : base(context)
    {
    }

}
