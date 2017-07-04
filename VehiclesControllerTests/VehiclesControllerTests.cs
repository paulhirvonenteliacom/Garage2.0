using System;
using Garage2._0.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GarageTests
{
    [TestClass]
    public class VehiclesControllerTest
    {
        [TestMethod]
        public void FeeForTwoMinutes()
        {
            //-- Arrange
            var vehiclesController = new VehiclesController();
            var timespan = new TimeSpan(0, 0, 2, 0);
            decimal expected = 10.0m;

            //-- Act
            var actual = vehiclesController.Fee(timespan);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
