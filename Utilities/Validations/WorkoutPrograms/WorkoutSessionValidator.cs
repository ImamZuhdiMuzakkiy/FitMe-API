using FitMe.API.DTOs.ProgramWorkouts.Requests;
using FluentValidation;

namespace FitMe.API.Utilities.Validations.WorkoutPrograms;

public class WorkoutSessionValidator : AbstractValidator<WorkoutSessionDTO>
{
    public WorkoutSessionValidator()
    {
        RuleFor(x => x.WorkoutSessionTitle)
            .NotEmpty().WithMessage("Workout Session Title Required");

        RuleFor(x => x.VideoUrl)
            .NotEmpty().WithMessage("Video URL Required");

        RuleFor(x => x.DurationMinutes)
            .NotEmpty().WithMessage("Duration Minutes Required");

        RuleFor(x => x.Instructions)
            .NotEmpty().WithMessage("Instructions Required");
    }
}
