namespace ParkNet.App.Data;

public class ParkNetDbContext : IdentityDbContext
{
    public ParkNetDbContext(DbContextOptions<ParkNetDbContext> options) : base(options) { }

    public DbSet<ParkingLot> ParkingLots { get; set; }
    public DbSet<ParkingFloor> ParkingFloors { get; set; }
    public DbSet<ParkingSpot> ParkingSpots { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}
