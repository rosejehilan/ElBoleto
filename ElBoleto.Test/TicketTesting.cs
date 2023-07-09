using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElBoleto.Test
{
    public class TicketTesting
    {
        [Fact]
        public void StartTrip()
        {

            //Arrange
            IBus bus = new Bus(1001, "11A");
            IPassenger passenger = new Passenger(5001, "890679803");
            var myTicket = new Ticket("8909887743", "37G",bus,passenger);
            //Act
            myTicket.busID = 10001;
            myTicket.StartTrip();
            //Assert
            Assert.NotNull(myTicket);
            Assert.Equal(10001, myTicket.busID);
            Assert.Equal((int)TripStatus.InProgress, myTicket.tripStatus);
            Assert.Equal("Nagercoil", myTicket.startingStation);
        }
        [Fact]
        public void EndTrip()
        {
            //Arrange
            IBus bus = new Bus(1001, "11A");
            IPassenger passenger = new Passenger(5001, "890679803");
            var myTicket = new Ticket("8909887743", "37G", bus, passenger);
            //Act
            myTicket.busID = 10001;
            myTicket.EndTrip();
            //Assert
            Assert.NotNull(myTicket);
            Assert.Equal(10001, myTicket.busID);
            Assert.Equal((int)TripStatus.Completed, myTicket.tripStatus);
            Assert.Equal("Kanyakumari", myTicket.endStation);
        }
    }
}
