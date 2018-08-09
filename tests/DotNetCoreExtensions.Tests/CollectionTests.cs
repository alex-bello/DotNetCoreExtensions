using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetCoreExtensions.Strings;
using System.Collections.Generic;

namespace DotNetCoreExtensions.Tests
{
    [TestClass]
    public class CollectionTests
    {
        [TestMethod]
        public void DictionaryGetValueOrDefaultTests()
        {
            // Assign
            var stringDictionary = new Dictionary<string, string> {
                {"Key1", "Value1"},
                {"Key2", "Value2"},
                {"Key3", "Value3"}
            };

            var intDictionary = new Dictionary<int, int> {
                {1, 5},
                {2, 6},
                {3, 7}
            };

            // Act


            // Assert
            Assert.AreEqual(stringDictionary.GetValueOrDefault("Key1"), "Value1");
            Assert.AreEqual(stringDictionary.GetValueOrDefault("Key2"), "Value2");
            Assert.AreEqual(stringDictionary.GetValueOrDefault("Key3"), "Value3");
            Assert.AreEqual(stringDictionary.GetValueOrDefault("DefaultValue"), default(string));
            Assert.AreEqual(intDictionary.GetValueOrDefault(1), 5);
            Assert.AreEqual(intDictionary.GetValueOrDefault(2), 6);
            Assert.AreEqual(intDictionary.GetValueOrDefault(3), 7);
            Assert.AreEqual(intDictionary.GetValueOrDefault(5), default(int));
        }
    }
}
