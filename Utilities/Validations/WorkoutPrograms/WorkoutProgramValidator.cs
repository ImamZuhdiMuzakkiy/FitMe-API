using FitMe.API.DTOs.ProgramWorkouts.Requests;
using FluentValidation;

namespace FitMe.API.Utilities.Validations.WorkoutPrograms;

public class WorkoutProgramValidator : AbstractValidator<WorkoutProgramRequest>
{
    public WorkoutProgramValidator()
    {
        RuleFor(x => x.WorkoutProgramTitle)
            .NotEmpty().WithMessage("Workout Program Title Required");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description Workout Program Required");

        RuleFor(x => x.Difficulty)
            .IsInEnum().WithMessage("Difficulty is not valid");

        RuleFor(x => x.DurationWeeks)
            .GreaterThan((ushort)0).WithMessage("Duration Weeks must be greater than 0");

        // ⛔ penting: validasi list dan elemen list
        RuleFor(x => x.Sessions)
            .NotNull().WithMessage("Sessions list must not be null")
            .NotEmpty().WithMessage("Workout Program must include at least one session");

        // Validasi tiap item dalam list
        RuleForEach(x => x.Sessions)
            .SetValidator(new WorkoutSessionValidator());
    }
}
