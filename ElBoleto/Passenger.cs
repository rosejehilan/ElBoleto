using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace ElBoleto
{
    public class Passenger
    {
        public Passenger(int _passengerID, string _cardNumber)
        {
            this.passengerID = _passengerID;
            this.cardNumber = _cardNumber;
            this.currentBalance = GetCurrentBalance();
        }
        public int passengerID { get; set; }
        public string ? firstName;
        public string ? lastName;
        public DateTime dateOfBirth;
        public string cardNumber { get; set; }
        public double currentBalance { get; set; }
        private double GetCurrentBalance()
        {
            return 100;//get it from database
        }
    }
}
