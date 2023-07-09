using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElBoleto.Test
{
    public class BusTesting
    {
        [Fact]
        public void GetCurrentStage()
        {
            //Arrange
            var myBus = new Bus(501, "7B");
            //Act
            myBus.tripID = 11;
            //Assert
            Assert.Equal(10, myBus.currentStage);

        }
    }
}
