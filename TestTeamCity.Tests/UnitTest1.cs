using NUnit.Framework;

namespace TestTeamCity.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(1, 1, 12)]
        public void GetSum_ValidArguments_ResulCorrectSum(int a, int b, int expectedSum)
        {
            var actualSum = Program.GetSum(a, b);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}