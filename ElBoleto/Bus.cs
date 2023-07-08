namespace ElBoleto
{
    public class Bus
    {
        public Bus(int _busID, string _routeNumber)
        {
            this.busID = _busID;
            this.routeNumber = _routeNumber;
            this.currentStage = getCurrentStage();
        }
        public int busID { get; set; }
        public string routeNumber { get; set; }
        public int tripID { get; set; }
        public int numberOfStages { get; set; }
        public int currentStage { get; set; }
        public double farePerStage { get; set; }
        public List<Passenger> passengers = new List<Passenger>();
        public List<Ticket> tickets = new List<Ticket>();
        private int getCurrentStage()
        {
            /*String CurrentLocation = CallGoogleMaps();
             this.currentStage = CalculateCurrentStage();*/

            return 10;
        }
    }
}
