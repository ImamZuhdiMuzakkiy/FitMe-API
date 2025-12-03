using System;
using System.Collections.Immutable;
using System.Linq;
using FitMe.API.DTOs.ProgramWorkouts.Requests;
using FitMe.API.DTOs.ProgramWorkouts.Responses;
using FitMe.API.Repositories;
using FitMe.API.Repositories.Interfaces;
using FitMe.API.Services.Interfaces;
using FitMe.API.Utilities;

namespace FitMe.API.Services;

public class WorkoutProgramService : IWorkoutProgramService
{
    private readonly IWorkoutProgramRepository _workoutProgramRespository;
    private readonly IWorkoutSessionRepository _workoutSessionRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IEmailHandler _emailHandler;

    public WorkoutProgramService(IWorkoutProgramRepository workoutProgramRepository, IWorkoutSessionRepository workoutSessionRepository, IUnitOfWork unitOfWork, IEmailHandler emailHandler)
    {
        _workoutProgramRespository = workoutProgramRepository;
        _workoutSessionRepository = workoutSessionRepository;
        _unitOfWork = unitOfWork;
        _emailHandler = emailHandler;
    }
    public async Task CreateWorkoutProgramAsync(WorkoutProgramRequest request, CancellationToken cancellationToken)
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
            Status = StatusWorkoutEnum.Pending,
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

        var email = new EmailDto(
            "imam@gmail.com",
            "Testing",
            $"{createProgramWorkout}"
        );
        await _emailHandler.SendEmailAsync(email);

        await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _workoutProgramRespository.CreateAsync(createProgramWorkout, cancellationToken);
        }, cancellationToken);
    }

    public async Task DeleteWorkoutProgramAsync(Guid id, CancellationToken cancellationToken)
    {
        var programWorkout = await _workoutProgramRespository.GetByIdAsync(id, cancellationToken);

        if (programWorkout is null)
        {
            throw new NullReferenceException("Program Workout not found");
        }
        
        await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _workoutProgramRespository.DeleteAsync(programWorkout);
        }, cancellationToken);
    }
    public async Task<IEnumerable<WorkoutProgramResponse>> GetAllWorkoutProgramAsync(CancellationToken cancellantionToken)
    {
        var getProgramWorkouts = await _workoutProgramRespository.GetAllAsync(cancellantionToken);
        if (!getProgramWorkouts.Any())
        {
            throw new NullReferenceException("No Program Workout");
        }

        var activeProgram = getProgramWorkouts
        .Where(p => p.Status == StatusWorkoutEnum.Active)
        .ToList();

        if(!activeProgram.Any())
        {
            throw new NullReferenceException("No Program Workout Active");
        }

        var getSessions = await _workoutSessionRepository.GetAllAsync(cancellantionToken);
        if (!getSessions.Any())
        {
            throw new NullReferenceException("No Program Workout Sessionfound");
        }

        var programWorkoutMap = activeProgram.GroupJoin(
            getSessions,
            p => p.WorkoutProgramId,
            s => s.WorkoutProgramId,
            (p, sessions) =>
                new WorkoutProgramResponse(
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
    
    // if(!programWorkoutMap.Status)

        return programWorkoutMap;
    }
    public async Task<WorkoutProgramResponse> GetWorkoutProgramByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var getProgramWorkout = await _workoutProgramRespository.GetByIdAsync(id, cancellationToken);

        if (getProgramWorkout is null)
        {
            throw new NullReferenceException("Program Workout ID not found");
        }

        // retrieve sessions and filter for this program id
        var allSessions = await _workoutSessionRepository.GetAllAsync(cancellationToken);
        var sessionsForProgram = allSessions.Where(s => s.WorkoutProgramId == id).ToList();

        var programWorkoutMap = new WorkoutProgramResponse(
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

    // public async Task UpdateWorkoutProgramAsync(Guid id, WorkoutProgramRequest request, CancellationToken cancellationToken)
    // {
    //     var programWorkout = await _workoutProgramRespository.GetByIdAsync(id, cancellationToken);

    //     if(programWorkout is null)
    //     {
    //         throw new Exception("Program Workout ID not found");
    //     }

    //         // programWorkout.UserId = request.CoachId;
    //         programWorkout.Title = request.WorkoutProgramTitle;
    //         programWorkout.Description = request.Description;
    //         programWorkout.Difficulty = request.Difficulty;
    //         programWorkout.DurationWeeks = request.DurationWeeks;
    //         // programWorkout.Status = request.Status;
    //         programWorkout.WorkoutSession = request.Sessions?.Select(s => new WorkoutSession
    //         {
    //             WorkoutSessionId = Guid.NewGuid(),
    //             Title = s.WorkoutSessionTitle,
    //             VideoUrl = s.VideoUrl,
    //             DurationMinutes = s.DurationMinutes,
    //             Instructions = s.Instructions
    //         }).ToList();

    //         await _unitOfWork.CommitTransactionAsync(async () =>
    //     {
    //         await _workoutProgramRespository.UpdateAsync(programWorkout);
    //     }, cancellationToken);
    // }

    public async Task<IEnumerable<WorkoutProgramResponse>> GetPendingProgramsAsync(CancellationToken cancellationToken)
    {
        // Ambil semua program dulu
        var programs = await _workoutProgramRespository.GetAllAsync(cancellationToken);

        var pendingPrograms = programs
            .Where(p => p.Status == StatusWorkoutEnum.Pending)
            .ToList();

        if (!pendingPrograms.Any())
            throw new NullReferenceException("No pending programs found");

        // Ambil semua sesi
        var sessions = await _workoutSessionRepository.GetAllAsync(cancellationToken);

        // Mapping program + sessions
        var result = pendingPrograms.GroupJoin(
            sessions,
            p => p.WorkoutProgramId,
            s => s.WorkoutProgramId,
            (p, s) =>
                new WorkoutProgramResponse(
                    p.WorkoutProgramId,
                    p.Title,
                    p.Description,
                    p.Difficulty,
                    p.DurationWeeks,
                    p.Status,
                    s.Select(sess => new WorkoutSessionResponse(
                        sess.WorkoutSessionId,
                        sess.Title,
                        sess.VideoUrl,
                        sess.DurationMinutes,
                        sess.Instructions
                    )).ToList()
                )
        ).ToList();

        return result;
    }

    public async Task ReviewProgramAsync(Guid id, ProgramReviewRequest request, CancellationToken cancellationToken)
    {
        var program = await _workoutProgramRespository.GetByIdAsync(id, cancellationToken);

        if (program is null)
            throw new NullReferenceException("Program not found");

        if (program.Status != StatusWorkoutEnum.Pending)
            throw new NullReferenceException("Program cannot be reviewed anymore");

        if (request.Status == StatusWorkoutEnum.Accepted)
        {
            program.Status = StatusWorkoutEnum.Accepted;
        }
        else if (request.Status == StatusWorkoutEnum.Rejected)
        {
            program.Status = StatusWorkoutEnum.Rejected;
        }
        else
        {
            throw new NullReferenceException("Invalid review status");
        }

        program.UpdatedAt = DateTime.UtcNow;

        await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _workoutProgramRespository.UpdateAsync(program);
        }, cancellationToken);
    }

    public async Task ToggleProgramStatusAsync(Guid id, CancellationToken cancellationToken)
    {
        var program = await _workoutProgramRespository.GetByIdAsync(id, cancellationToken);

        if (program is null)
            throw new NullReferenceException("Program not found");

        if (program.Status != StatusWorkoutEnum.Accepted &&
            program.Status != StatusWorkoutEnum.Active &&
            program.Status != StatusWorkoutEnum.Inactive)
        {
            throw new ArgumentException("Program must be accepted before activation");
        }

        program.Status = program.Status == StatusWorkoutEnum.Active
                        ? StatusWorkoutEnum.Inactive
                        : StatusWorkoutEnum.Active;

        program.UpdatedAt = DateTime.UtcNow;

        await _unitOfWork.CommitTransactionAsync(async () =>
        {
            await _workoutProgramRespository.UpdateAsync(program);
        }, cancellationToken);
    }
}
