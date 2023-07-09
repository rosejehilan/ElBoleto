using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace ElBoleto
{
    public class Passenger:IPassenger
    {
        public Passenger(int _passengerId, string _cardNumber)
        {
            this.passengerId = _passengerId;
            this.cardNumber = _cardNumber;
            this.currentBalance = GetCurrentBalance();
        }
        public int passengerId { get; set; }
        public string ? firstName { get; set; }
        public string ? lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string cardNumber { get; set; }
        public double currentBalance { get; set; }
        public double GetCurrentBalance()
        {
            return 100;//get it from database
        }
    }
}
