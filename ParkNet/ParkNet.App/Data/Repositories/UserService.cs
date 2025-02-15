namespace ParkNet.App.Data.Repositories;

public class UserService
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        return await _userRepository.GetByEmailAsync(email);
    }
}
