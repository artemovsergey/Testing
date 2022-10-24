using _2_2;

namespace _2_2_Tests
{
    public class MockMatrix : IDeterminantComputer
    {
        double[] determs;
        public MockMatrix(double[] dets)
        {
            determs = dets;
        }
        public int CallsCount { get; private set; } = 0;
        public double Determinant(double[,] matrix)
        {
            return determs[CallsCount++];
        }
    }
}
