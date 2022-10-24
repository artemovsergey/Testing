using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        public double[] x = new double[4] { 1, 1, 4, 4 };
        public double[] y = new double[4] { 0, 2, 2, 0 };

        public int[] a = new int[12] { 1, -3, 0, -1, 13, 5, 8, 1, 2, 3, 21, -3 };
        public int[] expected = new int[11] { -3, -1, 0, 1, 1, 2, 3, 5, 8, 13, 21 };

        [SetUp]
        public void Setup()
        {
        }

    // Ex.1
        [Test]
        public void TestDiagonalSquare()
        {
            // arrange
            ExerciseClasses.Rectangle rectangle = new ExerciseClasses.Rectangle(x, y);
            double expected = 13;

            // act
            double actual = rectangle.DiagonalSquare();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsRectangleTest()
        {
            // arrange
            ExerciseClasses.Rectangle rectangle = new ExerciseClasses.Rectangle(x, y);
            bool expected = true;

            // act
            bool actual = rectangle.IsRectangle();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]  
        public void TestRectWithSetter()
        {
            // arrange
            double[] expected = new double[4] { 2, 3, 2, 3 };
            ExerciseClasses.Rectangle rectWithSetter = new ExerciseClasses.Rectangle();

            // act
            rectWithSetter.SetVertices(x, y);
            double[] actualWithSetter = rectWithSetter.CalculateEdges(); 
            
            // assert
            Assert.AreEqual(expected, actualWithSetter);         
        }

        [Test]
        public void TestRectWithConstr()
        {
            // arrange
            double[] expected = new double[4] { 2, 3, 2, 3 };
            ExerciseClasses.Rectangle rectWithConstr = new ExerciseClasses.Rectangle(x, y);

            // act
            double[] actualWithConstr = rectWithConstr.CalculateEdges();

            // assert
            Assert.AreEqual(expected, actualWithConstr);
        }

    // Ex.2

        [Test]
        public void ArraySort()
        {
            // arrange
            int[] a = new int[12] { 1, -3, 0, -1, 13, 5, 8, 1, 2, 3, 21, -3 };
            int[] expected = new int[12] { -3, -3, -1, 0, 1, 1, 2, 3, 5, 8, 13, 21 };

            // act
            int[] actual = ExerciseClasses.ArrayProcessor.Sort(a);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayFilter()
        {
            // arrange
            int[] a = new int[12] { -3, -3, -1, 0, 1, 1, 2, 3, 5, 8, 13, 21 };

            // act
            int[] actual = ExerciseClasses.ArrayProcessor.Filter(a);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayFilterAndSort()
        {
            //arrange
            int[] a = new int[12] { 1, -3, 0, -1, 13, 5, 8, 1, 2, 3, 21, -3 };

            //act
            int[] actual = ExerciseClasses.ArrayProcessor.SortAndFilter(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}