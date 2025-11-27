using System;
using System.Collections.Immutable;
using System.Linq;
using FitMe.API.DTOs.ProgramWorkouts.Requests;
using FitMe.API.DTOs.ProgramWorkouts.Responses;
using FitMe.API.Repositories;
using FitMe.API.Repositories.Interfaces;
using FitMe.API.Services.Interfaces;

namespace FitMe.API.Services;

public class WorkoutProgramService : IWorkoutProgramService
{
    private readonly IWorkoutProgramRepository _workoutProgramRespository;
    private readonly IWorkoutSessionRepository _workoutSessionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public WorkoutProgramService(IWorkoutProgramRepository workoutProgramRepository, IWorkoutSessionRepository workoutSessionRepository, IUnitOfWork unitOfWork)
    {
        _workoutProgramRespository = workoutProgramRepository;
        _workoutSessionRepository = workoutSessionRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task CreateProgramWorkoutAsync(ProgramWorkoutRequest request, CancellationToken cancellationToken)
    {
        var programId = Guid.NewGuid();

        var createProgramWorkout = new WorkoutProgram
        {
            WorkoutProgramId = programId,
            UserId = request.CoachId,
            Title = request.WorkoutProgramTitle,
            Description = request.Description,
            Difficulty = request.Difficulty,
            DurationWeeks = request.DurationWeeks,
            Status = request.Status,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            WorkoutSession = request.Sessions?.Select(s => new WorkoutSession
            {
                WorkoutSessionId = Guid.NewGuid(),
                WorkoutProgramId = programId,
                Title = s.WorkoutSessionTitle,
                VideoUrl = s.VideoUrl,
                DurationMinutes = s.DurationMinutes,
                Instructions = s.Instructions
            }).ToList()
        };

        await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _workoutProgramRespository.CreateAsync(createProgramWorkout, cancellationToken);
        }, cancellationToken);
    }

    public async Task DeleteProgramWorkoutAsync(Guid id, CancellationToken cancellationToken)
    {
        var programWorkout = await _workoutProgramRespository.GetByIdAsync(id, cancellationToken);

        if (programWorkout is null)
        {
            throw new Exception("Program Workout not found");
        }
        
        await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _workoutProgramRespository.DeleteAsync(programWorkout);
        }, cancellationToken);
    }
    public async Task<IEnumerable<ProgramWorkoutResponse>> GetAllProgramWorkoutAsync(CancellationToken cancellantionToken)
    {
        var getProgramWorkouts = await _workoutProgramRespository.GetAllAsync(cancellantionToken);
        if (!getProgramWorkouts.Any())
        {
            throw new Exception("No Program Workouts found");
        }

        var getSessions = await _workoutSessionRepository.GetAllAsync(cancellantionToken);
        if (!getSessions.Any())
        {
            throw new Exception("No Program Workouts found");
        }

        var programWorkoutMap = getProgramWorkouts.GroupJoin(
            getSessions,
            p => p.WorkoutProgramId,
            s => s.WorkoutProgramId,
            (p, sessions) =>
                new ProgramWorkoutResponse(
                    p.WorkoutProgramId,
                    p.Title,
                    p.Description,
                    p.Difficulty,
                    p.DurationWeeks,
                    p.Status,
                    sessions.Select(s => new WorkoutSessionResponse(
                        s.WorkoutSessionId,
                        s.Title,
                        s.VideoUrl,
                        s.DurationMinutes,
                        s.Instructions)
                    ).ToList()
                )
        ).ToList();

        return programWorkoutMap;
    }
    public async Task<ProgramWorkoutResponse> GetWorkoutProgramByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var getProgramWorkout = await _workoutProgramRespository.GetByIdAsync(id, cancellationToken);

        if (getProgramWorkout is null)
        {
            throw new Exception("Program Workout ID not found");
        }

        // retrieve sessions and filter for this program id
        var allSessions = await _workoutSessionRepository.GetAllAsync(cancellationToken);
        var sessionsForProgram = allSessions.Where(s => s.WorkoutProgramId == id).ToList();

        var programWorkoutMap = new ProgramWorkoutResponse(
            getProgramWorkout.WorkoutProgramId,
            getProgramWorkout.Title,
            getProgramWorkout.Description,
            getProgramWorkout.Difficulty,
            getProgramWorkout.DurationWeeks,
            getProgramWorkout.Status,
            sessionsForProgram.Select(s => new WorkoutSessionResponse(
                s.WorkoutSessionId,
                s.Title,
                s.VideoUrl,
                s.DurationMinutes,
                s.Instructions)
            ).ToList()
        );

        return programWorkoutMap;
    }

    public async Task UpdateProgramWorkoutAsync(Guid id, ProgramWorkoutRequest request, CancellationToken cancellationToken)
    {
        var programWorkout = await _workoutProgramRespository.GetByIdAsync(id, cancellationToken);

        if(programWorkout is null)
        {
            throw new Exception("Program Workout ID not found");
        }

            programWorkout.UserId = request.CoachId;
            programWorkout.Title = request.WorkoutProgramTitle;
            programWorkout.Description = request.Description;
            programWorkout.Difficulty = request.Difficulty;
            programWorkout.DurationWeeks = request.DurationWeeks;
            programWorkout.Status = request.Status;
            programWorkout.WorkoutSession = request.Sessions?.Select(s => new WorkoutSession
            {
                WorkoutSessionId = Guid.NewGuid(),
                Title = s.WorkoutSessionTitle,
                VideoUrl = s.VideoUrl,
                DurationMinutes = s.DurationMinutes,
                Instructions = s.Instructions
            }).ToList();

            await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _workoutProgramRespository.UpdateAsync(programWorkout);
        }, cancellationToken);
    }

}
