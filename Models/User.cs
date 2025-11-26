
public class User
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }
    public GenderEnum Gender { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public uint? Otp { get; set; }
    public DateTime? Expired { get; set; }
    public bool IsUsed { get; set; }

    public DateTime UpdatedAt { get; set; }
    public DateTime CreatedAt { get; set; }

    
    //Cardinality
    public Role? Role    { get; set; }
    public ICollection<ProgramEnroll>? ProgramEnroll { get; set; }
    public ICollection<WorkoutProgram>? WorkoutProgram { get; set; }

}

//otp isUsed ditambahin

public enum GenderEnum
{
    Male, Female
}
