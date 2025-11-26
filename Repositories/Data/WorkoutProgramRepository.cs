using FitMe.API.Data;
using FitMe.API.Repositories.Interfaces;

namespace FitMe.API.Repositories.Data;

public class WorkoutProgramRepository : Repository<WorkoutProgram>, IWorkoutProgramRepository
{
    public WorkoutProgramRepository(FitMeDbContext context) : base(context)
    {
        
    }
}
