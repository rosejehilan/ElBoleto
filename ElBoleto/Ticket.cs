using System.Net.NetworkInformation;

namespace ElBoleto
{
    public enum TripStatus
    {
        InProgresss,
        Completed
    }
    public class Ticket : ITrip
    {
        public Ticket(string _cardId, string _routNumber, string _startingStation)
        {
            this.cardId = _cardId;
            this.routeNumber = _routNumber;
            this.startingStation = _startingStation;

        }
        public int TicketId { get; set; }
        public int passengerID { get; set; }
        public string cardId { get; set; }
        public int numberOfStages { get; set; }
        public double fare { get; set; }
        public int tripID { get; set; }
        public int busID { get; set; }
        public string routeNumber { get; set; }
        public int tripStatus { get; set; }
        public DateTime tripStart { get; set; }
        public DateTime tripEnd { get; set; }
        public string startingStation { get; set; }
        public string ? endStation { get; set; }
        public int startStage { get; set; }
        public int endStage { get; set; }

        public void StartTrip()
        {
            Bus myBus = new Bus(this.busID, this.routeNumber);
            this.startStage = myBus.currentStage;
            this.startingStation = "Nagercoil"; //CallGoogleMaps();
            this.tripStatus = (int)TripStatus.InProgresss;

        }
        public void EndTrip()
        {
            Bus myBus = new Bus(this.busID, this.routeNumber);
            Passenger myPassenger = new Passenger(passengerID, cardId);
            this.endStation = "Kanyakumari"; //CallGoogleMaps();
            this.endStage = myBus.currentStage;
            this.numberOfStages = endStage - startStage;
            this.fare = myBus.farePerStage * this.numberOfStages;
            this.tripStatus = (int)TripStatus.Completed;
            myPassenger.currentBalance = myPassenger.currentBalance - this.fare;
        }
    }
}

