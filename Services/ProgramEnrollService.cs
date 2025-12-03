using FitMe.API.DTOs.ProgramEnrolls.Requests;
using FitMe.API.DTOs.ProgramEnrolls.Responses;
using FitMe.API.Repositories;
using FitMe.API.Repositories.Data;
using FitMe.API.Repositories.Interfaces;
using FitMe.API.Services.Interfaces;

public class ProgramEnrollService : IProgramEnrollService
{
    private readonly IProgramEnrollRepository _programEnrollRepository;
    private readonly IUserRepository _userRepository;
    private readonly IWorkoutProgramRepository _workoutProgramRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ProgramEnrollService(IProgramEnrollRepository programEnrollRepository, IUnitOfWork unitOfWork, IUserRepository userRepository, IWorkoutProgramRepository workoutProgramRepository)
    {
        _programEnrollRepository = programEnrollRepository;
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _workoutProgramRepository = workoutProgramRepository;
    }

    public async Task EnrollAsync(Guid programId, Guid userId, ProgramEnrollRequest request, CancellationToken cancellationToken)
    {
        
        var user = await _userRepository.GetByIdAsync(userId, cancellationToken);
        if (user is null)
            throw new NullReferenceException("User not found");

        var program = await _workoutProgramRepository.GetByIdAsync(programId, cancellationToken);
        if (program is null)
            throw new NullReferenceException("Program not found");

        var programEnroll = new ProgramEnroll
        {
            ProgramEnrollId = Guid.NewGuid(), 
            UserId = userId,
            WorkoutProgramId = programId,
            StartDate = request.StartEnrollDate,
            Status = StatusProgramEnroll.InProgress,
            EndDate = null
        };

        await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _programEnrollRepository.CreateAsync(programEnroll, cancellationToken);
        }, cancellationToken);
    }

    public async Task<IEnumerable<ProgramEnrollListItemResponse>> GetMyEnrollmentsAsync(
    Guid userId,
    CancellationToken cancellationToken)
    {
        var enrollments = await _programEnrollRepository.GetByUserIdAsync(userId, cancellationToken);

        return enrollments.Select(e => new ProgramEnrollListItemResponse(
            e.ProgramEnrollId,
            // e.WorkoutProgramId,
            e.Status,
            e.StartDate,
            e.EndDate
        ));
    }

    public async Task CompleteEnrollmentAsync(Guid enrollmentId, CancellationToken cancellationToken)
    {
        var enrollment = await _programEnrollRepository.GetByIdAsync(enrollmentId, cancellationToken);

        if (enrollment == null)
            throw new Exception("Enrollment not found");

        enrollment.Status = StatusProgramEnroll.Completed;
        enrollment.EndDate = DateTime.UtcNow;

        await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _programEnrollRepository.UpdateAsync(enrollment);
        }, cancellationToken);
    }
}
