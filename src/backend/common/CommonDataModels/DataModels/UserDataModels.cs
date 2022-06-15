namespace Shared.DataModels.User;

public class UserCredentials
{
    public string Username { get; set; }
    public string Password { get; set; }

    // Equals method
    public override bool Equals(object? obj)
    {
        if (obj is UserCredentials userCredentials)
        {
            return Username == userCredentials.Username && Password == userCredentials.Password;
        }
        return false;
    }
}

public class UserData
{
    public int Id { get; set; }
    public UserCredentials Credentials { get; set; }
}