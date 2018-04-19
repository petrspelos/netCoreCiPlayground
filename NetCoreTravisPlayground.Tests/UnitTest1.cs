
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace NetCoreTravisPlayground.Tests
{
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.Pass();
        }

        [Test]
        public void DataTest()
        {
            const string expected = "Jon is 20 years old.";
            var actual = Program.DataToText("Jon", 20);

            Assert.AreEqual(expected, actual);
        }
    }
}
