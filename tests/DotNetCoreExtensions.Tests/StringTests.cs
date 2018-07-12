using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetCoreExtensions.Strings;

namespace DotNetCoreExtensions.Tests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void ToSnakeCaseTests()
        {
            // Assign
            var testNames = new string[] { "One",
                "OneTwo",
                "OneTwoThree",
                "One1TwoThree",
                "One1Two2Three",
                "OneTwo2Three",
                "OneTwoThreeFour"
                };

            // Act

            // Assert
            Assert.AreEqual(testNames[0].ToSnakeCase(), "one");
            Assert.AreEqual(testNames[1].ToSnakeCase(), "one_two");
            Assert.AreEqual(testNames[2].ToSnakeCase(), "one_two_three");
            Assert.AreEqual(testNames[3].ToSnakeCase(), "one1_two_three");
            Assert.AreEqual(testNames[4].ToSnakeCase(), "one1_two2_three");
            Assert.AreEqual(testNames[5].ToSnakeCase(), "one_two2_three");
            Assert.AreEqual(testNames[6].ToSnakeCase(), "one_two_three_four");
        }
    }
}
