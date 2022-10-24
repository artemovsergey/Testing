using _2_2;
using NUnit.Framework;

namespace _2_2_Tests
{
    [TestFixture]
    class LESWithMockTests
    {
        LinearEquationsSystem les;

        [Test]
        public void DetermHasCalled()
        {
            MockMatrix mdc = new MockMatrix(new[] { 1.0, 2.0, 3.0 });
            les = new LinearEquationsSystem(mdc);
            les.SetCoefficients(new[,] { { 1.0, 0.0, 3.0 }, { 2.0, 2.0, 4.5 } });
            les.Solve();

            Assert.That(mdc.CallsCount, Is.GreaterThan(0));
        }

        [Test]
        public void OnlyFirstCallDeterm()
        {
            MockMatrix mdc = new MockMatrix(new[] { 0.0, });
            les = new LinearEquationsSystem(mdc);
            les.SetCoefficients(new[,] { { 1.0, 0.0, 3.0 }, { 2.0, 2.0, 4.5 } });
            try
            {
                les.Solve();
            }
            catch { }

            Assert.That(mdc.CallsCount, Is.EqualTo(1));
        }

        [Test]
        public void ThreeTimesCalledDeterm()
        {
            MockMatrix mdc = new MockMatrix(new[] { 1.0, 2.0, 3.0 });
            les = new LinearEquationsSystem(mdc);
            les.SetCoefficients(new[,] { { 1.0, 0.0, 3.0 }, { 2.0, 2.0, 4.5 } });
            les.Solve();

            Assert.That(mdc.CallsCount, Is.EqualTo(3));
        }

    }
}
