using FitMe.API.Data;
using FitMe.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitMe.API.Repositories.Data;

public class WorkoutSessionRepository : Repository<WorkoutSession>, IWorkoutSessionRepository
{
    public WorkoutSessionRepository(FitMeDbContext context) : base(context)
    {
    }
}
