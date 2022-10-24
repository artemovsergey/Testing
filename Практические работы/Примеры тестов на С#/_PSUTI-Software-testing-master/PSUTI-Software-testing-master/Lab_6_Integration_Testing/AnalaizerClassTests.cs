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
    ///  Один из двух классов для автоматического юнит-тестирования методов,
    ///  которые интегрируют все модули в общую систему. Лабораторная работа №6.
    ///  Автор: Ежов Глеб
    /// </summary>
    [TestClass()]
    public class AnalaizerClassTests
    {
        /// <summary>
        /// Корректное выражение
        /// </summary>
        [TestMethod("Estimate: 152/2*(41+m29)")]
        public void EstimateTest1()
        {
            AnalaizerClass.expression = "152/2*(41+m29)";

            String expected = "912";
            String actual = AnalaizerClass.Estimate();
            Assert.AreEqual(expected, actual, "Estimate() не возвращает ожидаемое значение.");
        }

        /// <summary>
        /// Чисел и операторов в сумме больше 30
        /// </summary>
        [TestMethod("Estimate: 1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1")]
        public void EstimateTest2()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 16; ++i)
            {
                sb.Append("1+");
            }
            sb.Append("1");
            AnalaizerClass.expression = sb.ToString();

            String expected = "Error 08";
            String actual = AnalaizerClass.Estimate();
            Assert.AreEqual(expected, actual, "Estimate() не возвращает ожидаемое значение.");
        }

        /// <summary>
        /// Неправильная скобочная структура
        /// </summary>
        [TestMethod("Estimate: 3*(2+2))")]
        public void EstimateTest3()
        {
            AnalaizerClass.expression = "3*(2+2))";

            String expected = "Error 01 at 7";
            String actual = AnalaizerClass.Estimate();
            Assert.AreEqual(expected, actual, "Estimate() не возвращает ожидаемое значение.");
        }
    }
}