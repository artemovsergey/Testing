using NUnit.Framework;
using System.IO;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // arrange
            System.DateTime time = System.DateTime.Now;
            Logger.Log testLog = new Logger.Log(time, Logger.ActionType.login_correct, "Тимофей Шарий");
            string expected = $"{time} |        Тимофей Шарий | LOGIN: Access granted";

            // act
            Logger.Logger logger = new Logger.Logger();
            string actual = logger.addLog(testLog);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}