using Microsoft.VisualStudio.TestTools.UnitTesting;
using Garage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Tests
{
    [TestClass()]
    public class GarageListTests
    {
        [TestMethod()]
        public void CreateList_WithCapacity_ReturnsCapacity()
        {
            //Arrange
            const int expected = 13;
            var array = new GarageList<Vehicle>(expected);
            //Act
            var actual = array.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateList_WithZeroCapacity_Works()
        {
            const int expected = 0;
            var array = new GarageList<Vehicle>(expected);

            var actual = array.Capacity;
            //bool added = array.Add();
            int count = array.Count;

            Assert.AreEqual(expected, actual);
            //Assert.IsFalse(added);
            Assert.AreEqual(expected, count);
        }


    }

}