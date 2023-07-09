namespace ElBoleto
{
    public interface ITrip
    {
        int tripId { get; set; }
        int busID { get; set; }
        string ? routeNumber { get; set; }
        int passengerID { get; set; }
        int tripStatus { get; set; }
        DateTime tripStart { get; set; }
        DateTime tripEnd { get; set; }
        string ? startingStation { get; set; }
        string ? endStation { get; set; }
        int startStage { get; set; }
        int endStage { get; set; }
        void StartTrip();
        void EndTrip();
    }
}
