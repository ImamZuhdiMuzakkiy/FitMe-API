namespace FitMe.API.Data;

public static class FitMeDataSeeder
{
    private static readonly Guid _adminId = new Guid("10000000-0000-0000-0000-000000000001");
    private static readonly Guid _coachId = new Guid("10000000-0000-0000-0000-000000000002");
    private static readonly Guid _memberId = new Guid("10000000-0000-0000-0000-000000000003");

    public static List<Role> GetDefaultRoles()
    {
        return new List<Role>
        {
            new Role {RoleId = _adminId, Name = "Admin", Description = "Admin can control dashboard"},
            new Role {RoleId = _coachId, Name = "Coach", Description = "Coach can make new program workout"},
            new Role {RoleId = _memberId, Name = "Member", Description = "Member can follow programworkout"}
        };
    }

    public static List<User> GetDefaultUser()
    {
        return new List<User>
        {
            new User {UserId = Guid.NewGuid(), RoleId = _adminId, Email = "admin1@gmail.com", Password = "12345", Age = 25, Gender = GenderEnum.Male, Height = 175, Weight = 65, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
            new User {UserId = Guid.NewGuid(), RoleId = _coachId, Email = "coach1@gmail.com", Password = "123456", Age = 30, Gender = GenderEnum.Male, Height = 175, Weight = 65, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
            new User {UserId = Guid.NewGuid(), RoleId = _coachId, Email = "coach2@gmail.com", Password = "123456", Age = 30, Gender = GenderEnum.Female, Height = 175, Weight = 65, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
            new User {UserId = Guid.NewGuid(), RoleId = _memberId, Email = "member1@gmail.com", Password = "123", Age = 30, Gender = GenderEnum.Female, Height = 175, Weight = 65, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
        };
    }
}
