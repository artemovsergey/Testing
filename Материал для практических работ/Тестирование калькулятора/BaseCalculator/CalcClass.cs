using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BaseCalculator
{
    public class CalcClass
    {
        /// <summary>
        /// Последнне сообщение об ошибке.
        /// И хороший пример для регрессионного тестирования!
        /// </summary>
        private static string _lastError = "";

        public static string lastError
        {
            get
            {
                string temp = _lastError;
                _lastError = "";
                return temp;
            }
        }

        public static double Sinus(double x)
        {
            return Math.Sin(x);
        }

        public static double Cosinus(double x)
        {
            return Math.Cos(x);
        }

        public static double Thangens(double x)
        {
            return Math.Tan(x);
        }

        public static double Cothangens(double x)
        {
            return 1 / Math.Tan(x);
        }

        public static double Exp(double x)
        {
            return Math.Exp(x);
        }

        public static double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="a">слагаемое</param>
        /// <param name="b">слагаемое</param>
        /// <returns>сумма</returns>
        public static int Add(long a, long b)
        {
            if (a <= int.MaxValue && b <= int.MaxValue && a >= int.MinValue && b >= int.MinValue && a + b >= int.MinValue && a + b <= int.MaxValue)
            {
                return Convert.ToInt32(a + b);
            }
            else
            {
                _lastError = "Error 06";
                MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                Program.res = 6;
                return 0;
            }
        }

        /// <summary>
        /// вычитание
        /// </summary>
        /// <param name="a">уменьшаемое</param>
        /// <param name="b">вычитаемое</param>
        /// <returns>разность</returns>
        public static int Sub(long a, long b)
        {
            if (a <= int.MaxValue && b <= int.MaxValue && a >= int.MinValue && b >= int.MinValue && a - b >= int.MinValue && a - b <= int.MaxValue)
            {
                return Convert.ToInt32(a - b);
            }
            else
            {
                _lastError = "Error 06";
                MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                Program.res = 6;
                return 0;
            }
        }

        /// <summary>
        /// умножение
        /// </summary>
        /// <param name="a">множитель</param>
        /// <param name="b">множитель</param>
        /// <returns>произведение</returns>
        public static int Mult(long a, long b)
        {
            if (a <= int.MaxValue && b <= int.MaxValue && a >= int.MinValue && b >= int.MinValue && a * b >= int.MinValue && a * b <= int.MaxValue)
            {
                return Convert.ToInt32(a * b);
            }
            else
            {
                _lastError = "Error 06";
                MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                Program.res = 6;
                return 0;
            }
        }

        /// <summary>
        /// частное
        /// </summary>
        /// <param name="a">делимое</param>
        /// <param name="b">делитель</param>
        /// <returns>частное</returns>
        public static int Div(long a, long b)
        {
            if (a <= int.MaxValue && b <= int.MaxValue && a >= int.MinValue && b >= int.MinValue)
            {
                if (b != 0)
                {
                    long c;
                    long res = Math.DivRem(a, b, out c);
                    if (res >= int.MinValue && res <= int.MaxValue)
                    {
                        return Convert.ToInt32(res);
                    }
                    else
                    {
                        _lastError = "Error 06";
                        MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                        Program.res = 6;
                        return 0;
                    }
                }
                else
                {
                    _lastError = "Error 09";
                    MessageBox.Show("Ошибка деления на 0");
                    Program.res = 9;
                    return 0;
                }
            }
            else
            {
                _lastError = "Error 06";
                MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                Program.res = 6;
                return 0;
            }
        }

        /// <summary>
        /// Деление по модулю
        /// </summary>
        /// <param name="a">делимое</param>
        /// <param name="b">делитель</param>
        /// <returns>остаток</returns>
        public static int Mod(long a, long b)
        {
            if (a <= int.MaxValue && b <= int.MaxValue && a >= int.MinValue && b >= int.MinValue)
            {
                if (b != 0)
                {
                    long c;
                    Math.DivRem(a, b, out c);
                    if (c >= int.MinValue && c <= int.MaxValue)
                    {
                        return Convert.ToInt32(c);
                    }
                    else
                    {
                        _lastError = "Error 06";
                        MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                        Program.res = 6;
                        return 0;
                    }
                }
                else
                {
                    _lastError = "Error 09";
                    MessageBox.Show("Ошибка деления на 0");
                    Program.res = 9;
                    return 0;
                }
            }
            else
            {
                _lastError = "Error 06";
                MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                Program.res = 6;
                return 0;
            }
        }

        /// <summary>
        /// унарный плюс =)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int ABS(long a)
        {
            if (a <= int.MaxValue && a >= int.MinValue && Math.Abs(a) <= int.MaxValue && Math.Abs(a)>=int.MinValue)
            {
                // легко сделать глюк
                return Convert.ToInt32(Math.Abs(a));
            }
            else
            {
                _lastError = "Error 06";
                MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                Program.res = 6;
                return 0;
            }
        }

        /// <summary>
        /// унарный минус =)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int IABS(long a)
        {
            if (a < int.MaxValue && a > int.MinValue && -Math.Abs(a) <= int.MaxValue && -Math.Abs(a) >= int.MinValue)
            {
                return Convert.ToInt32(-Math.Abs(a));
            }
            else
            {
                _lastError = "Error 06";
                MessageBox.Show("Слишком малое или слишком большое значение числа для int\n Числа должны быть в пределах от -2147483648 до 2147483647");
                Program.res = 6;
                return 0;
            }
        }

        public static double Cube(double x)
        {
            return Math.Pow(x, 3.0);
        }

        public static double Square(double x)
        {
            return Math.Pow(x, 2.0);
        }

        public static double Lg(double x)
        {
            return Math.Log10(x);
        }

        public static double Ln(double x)
        {
            return Math.Log(x);
        }

        public static double Reciprocal(double x)
        {
            return 1 / x;
        }

        public static long Factor(int n)
        {
            long answ = 1;
            for (int i = 1; i <= n; i++)
            {
                answ *= i;
            }
            return answ;
        }

        public static double Pi
        {
            get
            {
                return Math.PI;
            }

        }

        public static double E
        {
            get
            {
                return Math.E;
            }
        }

        
    }
}
