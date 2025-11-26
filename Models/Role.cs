public class Role
{
    public Guid RoleId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<User>? User { get; set; }
}

