using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetCoreExtensions.Dates;

namespace DotNetCoreExtensions.Tests
{
    [TestClass]
    public class DateTests
    {
        [TestMethod]
        public void IsNotFutureDateTests()
        {
            // Assign
            var testDates = new DateTime[] { DateTime.Parse(@"01/01/2017"),
                DateTime.Now,
                DateTime.Now.AddDays(1),
                DateTime.Now.AddDays(30)
                };

            // Act

            // Assert
            Assert.IsFalse(testDates[0].IsFuture());
            Assert.IsFalse(testDates[1].IsFuture());
            Assert.IsTrue(testDates[2].IsFuture());
            Assert.IsTrue(testDates[3].IsFuture());
        }
    }
}