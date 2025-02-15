namespace ParkNet.App.Data.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly ParkNetDbContext _context; 
    protected readonly DbSet<T> _dbSet;
    // _context visível para as classes filhas

    public Repository(ParkNetDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity == null)
        {
            throw new KeyNotFoundException("Entity not found.");
        }

        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}