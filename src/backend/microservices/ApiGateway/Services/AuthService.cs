
using Shared.DataModels.User;

namespace ApiGateway.Services;

public class AuthService
{
    private const int InitialUsersNumber = 20;
    private List<UserData> UsersList { get; set; }

    public AuthService()
    {
        // Initialize UsersList with dummy users
        UsersList = new List<UserData>();

        // Id == Username == Password == i
        for (int i = 0; i < InitialUsersNumber; i++)
        {
            UsersList.Add(new UserData
            {
                Id = i,
                Credentials = new UserCredentials()
                {
                    Username = i.ToString(),
                    Password = i.ToString()
                }
            }
            );
        }
    }

    // Check if UserList
    public UserData? FindUser(UserCredentials userCredentials)
    {
        // Check if UsersList contains userData
        return UsersList.Find(c => c.Credentials.Equals(userCredentials));
    }
}