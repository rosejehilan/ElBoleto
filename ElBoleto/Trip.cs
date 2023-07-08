namespace ElBoleto
{
    public class Trip : ITrip
    {
        public int tripID { get; set; }
        public int busID { get; set; }
        public string routeNumber { get; set; }
        public int passengerID { get; set; }
        public int tripStatus { get; set; }
        public DateTime tripStart { get; set; }
        public DateTime tripEnd { get; set; }
        public string startingStation { get; set; }
        public string ? endStation { get; set; }
        public int startStage { get; set; }
        public int endStage { get; set; }
    }
}
