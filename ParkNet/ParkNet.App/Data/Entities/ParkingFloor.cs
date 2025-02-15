namespace ParkNet.App.Data.Entities;

//ParkingFloor → Pisos do estacionamento.
public class ParkingFloor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ParkingLotId { get; set; }
    public ParkingLot ParkingLot { get; set; }
    public ICollection<ParkingSpot> Spots { get; set; }
}
