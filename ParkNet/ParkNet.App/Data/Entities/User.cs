namespace ParkNet.App.Data.Entities;

//User → Utilizadores do sistema (Clientes e Administradores).
public class User : IdentityUser
{
    public string LicenseNumber { get; set; }
    public decimal Balance { get; set; }
    public ICollection<Subscription> Subscriptions { get; set; }
    public ICollection<Transaction> Transactions { get; set; }
}
