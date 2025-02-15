namespace ParkNet.App.Data.Entities;

//ParkingLot → Parques de estacionamento com múltiplos pisos.
public class ParkingLot
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public ICollection<ParkingFloor> Floors { get; set; }
}
