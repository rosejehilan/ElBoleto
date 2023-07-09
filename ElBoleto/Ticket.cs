using System.Net.NetworkInformation;

namespace ElBoleto
{
    public enum TripStatus
    {
        InProgress,
        Completed
    }


    public class Ticket : ITrip
    {
        private readonly IBus bus;
        private readonly IPassenger passenger;

        public Ticket(string _cardId, string _routeNumber, IBus bus, IPassenger _passenger)
        {
            this.cardId = _cardId;
            this.routeNumber = _routeNumber;
            this.bus = bus;
            this.passenger = _passenger;
        }
        public  string cardId { get; set; }
        public int ticketId { get; set; }
        public int numberOfStages { get; set; }
        public double Fare { get; set; }
        public int tripId { get; set; }
        public int tripStatus { get; set; }
        public DateTime tripStart { get; set; }
        public DateTime tripEnd { get; set; }
        public string? endStation { get; set; }
        public int startStage { get; set; }
        public int endStage { get; set; }
        public int busID { get; set; }
        public string routeNumber { get; set; }
        public int passengerID { get; set; }
        public string ? startingStation { get; set; }
        

        public void StartTrip()
        {
            this.startStage = bus.currentStage;
            this.startingStation = "Nagercoil"; // CallGoogleMaps();
            this.tripStatus =(int)TripStatus.InProgress ;
        }

        public void EndTrip()
        {
            this.endStation = "Kanyakumari"; // CallGoogleMaps();
            this.endStage = bus.currentStage;
            this.numberOfStages = this.endStage - this.startStage;
            this.Fare = bus.farePerStage * this.numberOfStages;
            this.tripStatus = (int)TripStatus.Completed;
            //Need to update the passenger balance
           // this.passenger.currentBalance -= this.Fare; 
        }
    }
}
