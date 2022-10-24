using NUnit.Framework;

namespace _2_2_Tests
{
    [TestFixture]
    public class MatrixTests
    {
        public _2_2.Matrix _m = new _2_2.Matrix();

        [Test]
        public void Determinant_1001_Test()
        {
            Assert.That(_m.Determinant(new double[,] { { 1.0, 0.0 }, { 0.0, 1.0 } }), Is.EqualTo(1.0));
        }

        [Test]
        public void Determinant_0110_Test()
        {
            Assert.That(_m.Determinant(new double[,] { { 0.0, 1.0 }, { 1.0, 0.0 } }), Is.EqualTo(-1.0));
        }

        [Test]
        public void Determinant_1111_Eq0_Test()
        {
            Assert.That(_m.Determinant(new double[,] { { 1.0, 1.0 }, { 1.0, 1.0 } }), Is.EqualTo(0.0));
        }
    }
}