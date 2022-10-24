using _2_2;
using NUnit.Framework;
using System;

namespace _2_2_Tests
{
    [TestFixture]
    class LESWithStubTests
    {
        LinearEquationsSystem les;

        private static object[][] wrongCoefficients_tests = new[] {
            new object[] {new [,]{{1.0}, {2.0}, {3.0}, {4.0}, {5.0}}},
            new object[] {new [,]{{1.0, 3.0}, {2.0, 3.0}}},
            new object[] {new [,]{{1.0, 3.0, 0, 1}, {2.0, 3.0, 0, 0.0}}}
        };

        private static object[][] rightCoefficients_tests = new[] {
            new object[] {new [,]{{1.0, 0.0, 3.0}, {2.0, 2.0, 4.5}} },
            new object[] {new [,]{{1.0, 3.0, 2.3}, {2.0, 3.0, 0.256}}},
            new object[] {new [,]{{1.0, 0.023, 0.1}, {2.0, 3.0, 10.0}} }
        };

        [TestCaseSource("wrongCoefficients_tests")]
        public void WrongCoefficientsException(double[,] arr)
        {
            les = new LinearEquationsSystem(new StubMatrix(null));
            Assert.Throws<ArgumentException>(() => les.SetCoefficients(arr));
        }

        [TestCaseSource("rightCoefficients_tests")]
        public void RightCoefficientsTest(double[,] arr)
        {
            les = new LinearEquationsSystem(new StubMatrix(null));
            Assert.DoesNotThrow(() => les.SetCoefficients(arr));
        }

        private static object[][] rightDeterm_tests = new[] {
            new object[] {new [,]{{1.0, 0.0, 3.0}, {2.0, 2.0, 4.5}}, new[] {2.0, 6, -1.5}, new[] { 3.0, -0.75} }
        };

        [TestCaseSource("rightDeterm_tests")]
        public void RightDetermTest(double[,] arr, double[] det, double[] roots)
        {
            les = new LinearEquationsSystem(new StubMatrix(det));
            les.SetCoefficients(arr);
            Assert.That(les.Solve(), Is.EqualTo(roots));
        }

        [TestCaseSource("rightCoefficients_tests")]
        public void WrongSolve_ZeroDeterminant(double[,] arr)
        {
            les = new LinearEquationsSystem(new StubMatrix(new[] { 0.0, }));
            les.SetCoefficients(arr);
            Assert.Throws<ArithmeticException>(() => les.Solve());
        }
    }
}
