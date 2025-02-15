namespace ParkNet.App.Data.Repositories;

public class UserRepository : Repository<User>
{
    public UserRepository(ParkNetDbContext context) : base(context) { }

    // Aqui podemos adicionar métodos específicos para o repositório de User
    public async Task<User> GetByEmailAsync(string email)
    {
        return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
    }
}
