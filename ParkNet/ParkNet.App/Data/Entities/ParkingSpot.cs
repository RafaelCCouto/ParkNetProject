namespace ParkNet.App.Data.Entities;

//ParkingSpot → Lugares de estacionamento (Motos e Carros).
public class ParkingSpot
{
    public int Id { get; set; }
    public string Identifier { get; set; }
    public bool IsOccupied { get; set; }
    public string VehicleType { get; set; } // Car or Motorcycle
    public int FloorId { get; set; }
    public ParkingFloor Floor { get; set; }
}
