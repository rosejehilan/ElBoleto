namespace ElBoleto
{
    public interface IBus
    {
        public int busID { get;  }
        public string routeNumber { get;  }
        public int tripID { get;  }
        public int numberOfStages { get; set; }
        public int currentStage { get;  }
        public double farePerStage { get;  }
        public int driverId { get; }
        public int conductorID { get; }
        public List<Ticket> tickets { get; }
        int getCurrentStage();
        
    }
}
