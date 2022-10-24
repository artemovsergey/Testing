using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCalculator.Tests
{
    /// <summary>
    /// Тестирование метода Main(). Завершение интеграционного
    /// тестирование системы.
    /// </summary>
    [TestClass()]
    public class ProgramTests
    {
        /// <summary>
        /// Корректное выражение
        /// </summary>
        [TestMethod("Main: 152/2*(41+m29)")]
        public void MainTest1()
        {
            string[] args = new string[1];
            args[0] = "152/2*(41+m29)";


            int expected = 0;
            int actual = Program.Main2(args);
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }

        /// <summary>
        /// Неправильная скобочная структура
        /// </summary>
        [TestMethod("Main: 3*(2+2))")]
        public void MainTest2()
        {
            string[] args = new string[1];
            args[0] = "3*(2+2))";

            Program.Main2(args);
            int expected = 1;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает хранит неправильное значение");
        }

        /// <summary>
        /// Неизвестный оператор
        /// </summary>
        [TestMethod("Main: 5432modz3")]
        public void MainTest3()
        {
            string[] args = new string[1];
            args[0] = "5432modz3";

            Program.Main2(args);
            int expected = 2;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }

        /// <summary>
        /// Неверная синтаксическая конструкция на входе
        /// </summary>
        [TestMethod("Main: /(2+2)")]
        public void MainTest4()
        {
            string[] args = new string[1];
            args[0] = "/(2+2)";

            Program.Main2(args);
            int expected = 3;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }

        /// <summary>
        /// Два оператора подряд
        /// </summary>
        [TestMethod("Main: 5-3**2")]
        public void MainTest5()
        {
            string[] args = new string[1];
            args[0] = "5-3**2";

            Program.Main2(args);
            int expected = 4;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }

        /// <summary>
        /// Незаконченное выражение
        /// </summary>
        [TestMethod("Main: 3*(2)+")]
        public void MainTest6()
        {
            string[] args = new string[1];
            args[0] = "3*(2)+";

            Program.Main2(args);
            int expected = 5;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }

        /// <summary>
        /// Слишком длинное выражение
        /// </summary>
        [TestMethod("Main: [65534 единицы]+11")]
        public void MainTest7()
        {
            string[] args = new string[1];

            StringBuilder longExpression = new StringBuilder("");
            for (int i = 0; i < 65534; ++i)
            {
                longExpression.Append("1");
            }
            longExpression.Append("+11");

            args[0] = longExpression.ToString();

            Program.Main2(args);
            int expected = 7;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }

        /// <summary>
        /// Слишком малое или слишком большое значение числа для int
        /// </summary>
        [TestMethod("Main: (2147483500-m2147483500)/2")]
        public void MainTest8()
        {
            string[] args = new string[1];
            args[0] = "(2147483500-m2147483500)/2";

            Program.Main2(args);
            int expected = 6;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }

        /// <summary>
        /// Суммарное кол-во чисел и операторов превышает 30
        /// </summary>
        [TestMethod("Main: 1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1")]
        public void MainTest9()
        {
            string[] args = new string[1];
            args[0] = "1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1";

            Program.Main2(args);
            int expected = 8;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }

        /// <summary>
        /// Ошибка деления на нуль
        /// </summary>
        [TestMethod("Main: 34/0")]
        public void MainTest10()
        {
            string[] args = new string[1];
            args[0] = "34/0";

            Program.Main2(args);
            int expected = 9;
            int actual = Program.res;
            Assert.AreEqual(expected, actual, "Main() возвращает неправильное значение");
        }
    }
}