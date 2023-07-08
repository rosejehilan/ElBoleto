namespace ElBoleto
{
    public interface ITrip
    {
        int tripID { get; set; }
        int busID { get; set; }
        string ruteNumber { get; set; }
        int passengerID { get; set; }
        int tripStatus { get; set; }
        DateTime tripStart { get; set; }
        DateTime tripEnd { get; set; }
        string startingStation { get; set; }
        string endStation { get; set; }
        int startStage { get; set; }
        int endStage { get; set; }
    }
}
