using System;

namespace _2_2
{
    public class Matrix : IDeterminantComputer
    {
        public double Determinant(double[,] matrix) 
        {
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
                throw new ArgumentException("Ошибка! Ожидаемая размерность 2 на 2!");
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
    }
}
