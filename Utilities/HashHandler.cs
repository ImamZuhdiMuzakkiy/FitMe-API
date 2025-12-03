namespace FitMe.API.Utilities;

public interface IHashHandler
{
    string GenerateHash(string password);
    bool ValidateHash(string password, string hash);
}
public class HashHandler: IHashHandler
{
    // SALT
    private string GenerateSalt()
    {
        return BCrypt.Net.BCrypt.GenerateSalt(12);
    }
    // Generate Hash
    public string GenerateHash(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password, GenerateSalt());
    }
    // Validation Hash
    public bool ValidateHash(string password, string hash)
    {
        return BCrypt.Net.BCrypt.Verify(password, hash);
    }
}
