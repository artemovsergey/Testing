using _2_2;

namespace _2_2_Tests
{
    public class StubMatrix : IDeterminantComputer
    {
        double[] determinant;
        int i = 0;
        public StubMatrix(double[] returnedDet)
        {
            determinant = returnedDet;
        }
        public double Determinant(double[,] matrix)
        {
            return determinant[i++];
        }
    }
}
