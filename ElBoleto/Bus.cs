namespace ElBoleto
{
    public class Bus:IBus
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
        public int driverId { get; set; }
        public int conductorID { get; set; }
        public List<Ticket> tickets { get; set; }
        public int getCurrentStage()
        {
            /*String CurrentLocation = CallGoogleMaps();
             this.currentStage = CalculateCurrentStage();*/

            return 10;
        }
    }
}
