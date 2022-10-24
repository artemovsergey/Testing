using _2_2;
using Moq;
using NUnit.Framework;

namespace _2_2_Tests
{
    [TestFixture]
    public class LESWithMoqTests
    {
        Mock<IDeterminantComputer> _mockMatrix;
        LinearEquationsSystem _les;

        [SetUp]
        public void InitTests()
        {
            _mockMatrix = new Mock<IDeterminantComputer>();
            _les = new LinearEquationsSystem(_mockMatrix.Object);
        }

        //[Test]
        //public void DetermHasCalledAtLeastOnce()
        //{
        //    _les.SetCoefficients(new double[,] { { 1.0, 0.0, 3.0 }, { 2.0, 2.0, 4.5 } });
        //    _les.Solve();
        //    _mockMatrix.Verify(x => x.Determinant(It.IsAny<double[,]>()));
        //}

        [Test]
        public void DetermHasCalledThreeTimes()
        {
            _mockMatrix.Setup(x => x.Determinant(It.IsAny<double[,]>()))
                       .Returns(1.0);
            _les.SetCoefficients(new double[,] { { 1.0, 0.0, 3.0 }, { 2.0, 2.0, 4.5 } });
            _les.Solve();
            _mockMatrix.Verify(x => x.Determinant(It.IsAny<double[,]>()), Times.Exactly(3));
        }

        //[Test]
        //public void DetermHasRightMatrix()
        //{
        //    _mockMatrix.Setup(x => x.Determinant(It.IsAny<double[,]>()))
        //               .Returns(1.0);
        //    var ch = new double[][,] {
        //        new double[,] { { 1.0, 0.0 }, { 2.0, 2.0 } },
        //        new double[,] { { 3.0, 0.0 }, { 4.5, 2.0 } },
        //        new double[,] { { 1.0, 3.0 }, { 2.0, 4.5 } }};

        //    int index = 0;
        //    _mockMatrix.Setup(x => x.Determinant(It.IsAny<double[,]>()));

        //    _les.SetCoefficients(new double[,] { { 1.0, 0.0, 3.0 }, { 2.0, 2.0, 4.5 } });
        //    try
        //    {
        //        _les.Solve();
        //    }
        //    catch { }


        //    // check all arguments where passed
        //    _mockMatrix.Verify(x => x.Determinant(It.Is<double[,]>(d => d.Equals(ch[index++]))));
        //}
    }
}
