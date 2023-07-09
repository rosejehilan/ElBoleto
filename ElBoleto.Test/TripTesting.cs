using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ElBoleto.Test
{
    public class TripTesting
    {
        [Fact]
        public void InitializeTrip()
        {
            //Arrange
            var myTrip =new Trip();

            //Act
            myTrip.busID = 1;
            myTrip.routeNumber = "11A";
            myTrip.tripStatus = 1;
            myTrip.endStage = 10;
            myTrip.startStage = 1;
            myTrip.tripId = 5;
            myTrip.passengerID = 6;
            myTrip.startingStation = "Nagercoil";
            myTrip.endStation = "Asaripallam";
            myTrip.tripStart = Convert.ToDateTime(Convert.ToDateTime("07/08/2023"));
            myTrip.tripEnd = Convert.ToDateTime("07/08/2023").AddHours(1);


            //Assert
            Assert.Equal(1, myTrip.busID);
            Assert.Equal("11A", myTrip.routeNumber);
            Assert.Equal(1, myTrip.tripStatus);
            Assert.Equal(10, myTrip.endStage);
            Assert.Equal(1, myTrip.startStage);
            Assert.Equal(5, myTrip.tripId);
            Assert.Equal(6, myTrip.passengerID);
            Assert.Equal("Nagercoil", myTrip.startingStation);
            Assert.Equal("Asaripallam", myTrip.endStation);
            Assert.Equal("7/8/2023", myTrip.tripStart.ToShortDateString());
            Assert.Equal("7/8/2023", myTrip.tripEnd.ToShortDateString());

        }
    }
}
