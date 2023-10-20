using NUnit.Framework;
using System;

namespace Lesson1.AutomationTesting

{
    [TestFixture]
    class SetUpTearDownTest
    {
        [SetUp]
        public void Initialization()
        {
            Console.WriteLine(">>Open browser");
            Console.WriteLine(">>Open web page");
            Console.WriteLine(">>Set browser options");
            //Assert.Fail();
        }

        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine(">>Close browser");
        }

        [Test]
        public void UserFunctionalityTest()
        {
            Console.WriteLine("........Check User Functionality.......");
            Assert.Pass("Test passed successfully");
        }

        [Test]
        public void CheckFail()
        {
            Console.WriteLine("........Check Fail .......");
            Assert.Fail("Test failed");
        }

    }
}