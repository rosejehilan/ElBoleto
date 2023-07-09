using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElBoleto.Test
{
    public class PassengerTesting
    {
        [Fact]
        public void GetBalance()
        {
            //Arrange
            var johnson = new Passenger(301, "490876543299");

            //Act
            johnson.dateOfBirth = Convert.ToDateTime("01/06/1981");

            //Assert
            Assert.Equal(100, johnson.currentBalance);

        }
    }
}
