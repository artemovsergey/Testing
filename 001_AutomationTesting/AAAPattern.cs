using NUnit.Framework;
using System;

namespace Lesson1.AutomationTesting
{
    public class Calculator
    {
        public Calculator()
        {
        }

        internal int Add(int v, int k)
        {
            return v + k;
        }
    }

    public class AAAPattern
    {

        [Test]
        public void Add_ZeroToValue_ReturnsValue()
        {
            // Arrange
            var calculator = new Calculator();
            Console.WriteLine("Add_ZeroToValue_ReturnsValue complete");
            // Assert
            Assert.AreEqual(5, calculator.Add(0, 5));
        }

        [Test]
        public void Add_ZeroToValue_ReturnsValue_Better()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(0, 5);

            // Assert
            Assert.AreEqual(5, actual);
        }

    }


}
