using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    public class LinearEquationsSystem
    {
        public double[,] coeff;
        IDeterminantComputer _matrix;

        public LinearEquationsSystem(IDeterminantComputer idet)
        {
            _matrix = idet;
        }

        public void SetCoefficients(double[,] coeffs) 
        {
            if (coeffs.GetLength(0) != 2 || coeffs.GetLength(1) != 3) 
                throw new ArgumentException("Ошибка! Ожидается система с двумя неизвестными!"); 

            double[,] newArray = new double[2, 3];
            
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    newArray[i, j] = coeffs[i, j];

            coeff = newArray;
        }

        public double[] Solve()
        {
            double[,] det_ar = { { coeff[0, 0], coeff[0, 1] }, { coeff[1, 0], coeff[1, 1] } };
            double det = _matrix.Determinant(det_ar);

            if (Math.Abs(det) < Math.Pow(10, -7))
                throw new ArithmeticException("Ощибка! Детерминант не может быть равен нулю!");

            double[,] x1_ar = { { coeff[0, 2], coeff[0, 1] }, { coeff[1, 2], coeff[1, 1] } };
            double x1 = _matrix.Determinant(x1_ar) / det;
            double[,] x2_ar = { { coeff[0, 0], coeff[0, 2] }, { coeff[1, 0], coeff[1, 2] } };
            double x2 = _matrix.Determinant(x2_ar) / det;

            return new[] { x1, x2 };
        }
    }
}
