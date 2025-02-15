namespace ParkNet.App.Data.Repositories;

public class ParkingLotRepository : Repository<ParkingLot>
{
    public ParkingLotRepository(ParkNetDbContext context) : base(context) { }

    // Exemplo de método específico para ParkingLot:
    public async Task<ParkingLot> GetByLocationAsync(string location)
    {
        return await _dbSet.FirstOrDefaultAsync(p => p.Location == location);
    }
}