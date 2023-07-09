namespace ElBoleto
{
    public interface IPassenger
    {
         int passengerId { get; }
         string? firstName { get; }
         string? lastName { get; }
         DateTime dateOfBirth { get; }
         string cardNumber { get; }
         double currentBalance { get; }
        double GetCurrentBalance();


    }
}
