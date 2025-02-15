namespace ParkNet.App.Data.Entities;

//Transaction → Registo de pagamentos e carregamentos.
public class Transaction
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; } // Payment, Recharge
}
