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
    ///  Класс для автоматического юнит-тестирования методов работы с памятью калькулятора из
    ///  класса BaseCalc проекта BaseCalculator с применением списков воспроизведения. Лабораторная работа №5.
    ///  Автор: Ежов Глеб
    /// </summary>
    [TestClass()]
    public class BaseCalcTests
    {
        // поля-строки - эмуляция текстбоксов, а exception для проверки ошибок
        private static String expression = "";
        private static String result = "";
        int exception = 0;

        // Написал копии методов работы с памятью калькулятора для тестирования
        // т.к. из BaseCalc класса их вызвать не получается
        public void bMR_ForTest()
        {
            expression += BaseCalc.mem.ToString();
        }

        public void bMPlus_ForTest()
        {
            if (result != "")
            {
                try
                {
                    BaseCalc.mem = CalcClass.Add(BaseCalc.mem, Convert.ToInt32(result));
                }
                catch (OverflowException ex)
                {
                    // Слишком малое или слишком большое значение числа для int\nЧисла должны быть в пределах от -2147483648 до 2147483647
                    exception = 1;
                }
                catch (Exception ex)
                {
                    // "Невозможно преобразовать к числу!", "Ошибка"
                    exception = 2;
                }
            }
        }

        public void bMC_ForTest()
        {
            BaseCalc.mem = 0;
        }

        [TestMethod("bMPlus_Click (пустая строка): \"\"")]
        public void bMPlus_ClickTest1()
        {
            AnalaizerClass.expression = "";
            result = AnalaizerClass.Estimate();
            int expected = 0;
            int actual = BaseCalc.mem;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("bMPlus_Click: 2")]
        public void bMPlus_ClickTest2()
        {
            AnalaizerClass.expression = "1+1";
            result = AnalaizerClass.Estimate();
            bMPlus_ForTest();

            int expected = 2;
            int actual = BaseCalc.mem;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("bMPlus_Click: -8")]
        public void bMPlus_ClickTest3()
        {
            AnalaizerClass.expression = "m5+m5";
            result = AnalaizerClass.Estimate();
            bMPlus_ForTest();

            int expected = -8;
            int actual = BaseCalc.mem;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("bMPlus_Click: 2147483648")]
        public void bMPlus_ClickTest4()
        {
            // result больше 2147483647 не сможет вернутся из CalcClass в любом случае, поэтому здесь искусственный result
            result = "2147483648";
            bMPlus_ForTest();

            int expected = 1;
            int actual = exception;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("bMPlus_Click: -2147483649")]
        public void bMPlus_ClickTest5()
        {
            // result меньше -2147483648 не сможет вернутся из CalcClass в любом случае, поэтому здесь искусственный result
            result = "-2147483649";
            bMPlus_ForTest();

            int expected = 1;
            int actual = exception;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("bMPlus_Click: Error 03")]
        public void bMPlus_ClickTest6()
        {
            AnalaizerClass.expression = "4/3m6";
            result = AnalaizerClass.Estimate();
            bMPlus_ForTest();

            int expected = 2;
            int actual = exception;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("bMR_ClickTest: 145+-8")]
        public void bMR_ClickTest1()
        {
            expression = "145+";
            bMR_ForTest();

            string expected = "145+-8";
            string actual = expression;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("bMC_ClickTest: 0")]
        public void bMC_ClickTest1()
        {
            bMC_ForTest();

            int expected = 0;
            int actual = BaseCalc.mem;

            Assert.AreEqual(expected, actual);
        }
    }
}