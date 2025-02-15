namespace ParkNet.App.Data.Entities;

// Subscription → Avenças dos clientes.
public class Subscription
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public int ParkingLotId { get; set; }
    public ParkingLot ParkingLot { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
