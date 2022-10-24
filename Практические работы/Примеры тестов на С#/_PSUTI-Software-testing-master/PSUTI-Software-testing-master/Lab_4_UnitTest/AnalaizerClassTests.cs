using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BaseCalculator.Tests
{
    /// <summary>
    ///  Класс для автоматического юнит-тестирования класса AnalaizerClass проекта BaseCalculator. Лабораторная работа №4.
    ///  Автор: Ежов Глеб
    /// </summary>
    [TestClass()]
    public class AnalaizerClassTests
    {
        // ЮНИТ-ТЕСТЫ МЕТОДА CheckCurrency()
        [TestMethod("CheckCurrency: 3*(2+2)")]
        public void CheckCurrencyTest1()
        {
            AnalaizerClass.expression = "3*(2+2)";
            bool expected = true;
            bool actual = AnalaizerClass.CheckCurrency();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("CheckCurrency: 3*(2+2))")]
        public void CheckCurrencyTest2()
        {
            AnalaizerClass.expression = "3*(2+2))";
            bool expected = false;
            bool actual = AnalaizerClass.CheckCurrency();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("CheckCurrency: ((2+2)*3")]
        public void CheckCurrencyTest3()
        {
            AnalaizerClass.expression = "((2+2)*3";
            bool expected = false;
            bool actual = AnalaizerClass.CheckCurrency();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("CheckCurrency: 9+(34-65*(4/2))")]
        public void CheckCurrencyTest4()
        {
            AnalaizerClass.expression = "9+(34-65*(4/2))";
            bool expected = true;
            bool actual = AnalaizerClass.CheckCurrency();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("CheckCurrency: 9+(34-65*((4/2))")]
        public void CheckCurrencyTest5()
        {
            AnalaizerClass.expression = "9+(34-65*((4/2))";
            bool expected = false;
            bool actual = AnalaizerClass.CheckCurrency();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("CheckCurrency: 9+(34-65*(4/2)))")]
        public void CheckCurrencyTest6()
        {
            AnalaizerClass.expression = "9+(34-65*(4/2)))";
            bool expected = false;
            bool actual = AnalaizerClass.CheckCurrency();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("CheckCurrency: 9+(34-65*(4/)2)")]
        public void CheckCurrencyTest7()
        {
            AnalaizerClass.expression = "9+(34-65*(4/)2)";
            bool expected = true;
            bool actual = AnalaizerClass.CheckCurrency();

            Assert.AreEqual(expected, actual);
        }

        // ЮНИТ-ТЕСТЫ МЕТОДА Format()
        [TestMethod("Format: 3*(2+")]
        public void FormatTest1()
        {
            AnalaizerClass.expression = "3*(2+";
            string expected = "&Error 05";
            string actual = AnalaizerClass.Format();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("Format: 5-3**2")]
        public void FormatTest2()
        {
            AnalaizerClass.expression = "5-3**2";
            string expected = "&Error 04 at 4";
            string actual = AnalaizerClass.Format();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("Format: 5432mod3")]
        public void FormatTest3()
        {
            AnalaizerClass.expression = "5432mod3";
            string expected = "5432 mod 3 ";
            string actual = AnalaizerClass.Format();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("Format: 5432modz3")]
        public void FormatTest4()
        {
            AnalaizerClass.expression = "5432modz3";
            string expected = "&Error 02 at 7";
            string actual = AnalaizerClass.Format();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("Format: p9+(mm34mod2-65*(4/2))")]
        public void FormatTest5()
        {
            AnalaizerClass.expression = "p9+(mm34mod2-65*(4/2))";
            string expected = "p 9 + ( m m 34 mod 2 - 65 * ( 4 / 2 ) ) ";
            string actual = AnalaizerClass.Format();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("Format: [65534 единицы]+11")]
        public void FormatTest7()
        {
            StringBuilder longExpression = new StringBuilder("");
            for (int i = 0; i < 65534; ++i)
            {
                longExpression.Append("1");
            }
            longExpression.Append("+11");

            AnalaizerClass.expression = longExpression.ToString();
            string expected = "&Error 07";
            string actual = AnalaizerClass.Format();

            Assert.AreEqual(expected, actual);
        }

        // ЮНИТ-ТЕСТЫ МЕТОДА CreateStack()
        [TestMethod("CreateStack: ( ( p 34 ) - 3 ) / 5 ")]
        public void CreateStackTest1()
        {
            AnalaizerClass.expression = "( ( p 34 ) - 3 ) / 5 ";
            ArrayList expected = new System.Collections.ArrayList(30);
            expected.Add("34");
            expected.Add("p");
            expected.Add("3");
            expected.Add("-");
            expected.Add("5");
            expected.Add("/");
            ArrayList actual = AnalaizerClass.CreateStack();

            bool isEqual = true;
            for (int i = 0; i < actual.Count; ++i)
            {
                if (expected[i].ToString() != actual[i].ToString()) isEqual = false;
            }

            Assert.AreEqual(true, isEqual);
        }

        [TestMethod("CreateStack: ( p 34 - 3 ) / 5 ")]
        public void CreateStackTest2()
        {
            AnalaizerClass.expression = "( p 34 - 3 ) / 5 ";
            ArrayList expected = new System.Collections.ArrayList(30);
            expected.Add("34");
            expected.Add("p");
            expected.Add("3");
            expected.Add("-");
            expected.Add("5");
            expected.Add("/");
            ArrayList actual = AnalaizerClass.CreateStack();

            bool isEqual = true;
            for (int i = 0; i < actual.Count; ++i)
            {
                if (expected[i].ToString() != actual[i].ToString()) isEqual = false;
            }

            Assert.AreEqual(true, isEqual);
        }

        [TestMethod("CreateStack: ( ( ( ( ( ( ( ( ( ( ( ( ( ( ( ( 1 + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) ")]
        public void CreateStackTest3()
        {
            AnalaizerClass.expression = "( ( ( ( ( ( ( ( ( ( ( ( ( ( ( ( 1 + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) + 1 ) ";

            Object actual = new object();
            if (AnalaizerClass.CreateStack() == null) actual = null;

            Assert.AreEqual(null, actual);
        }

        // ЮНИТ-ТЕСТЫ МЕТОДА RunEstimate()
        [TestMethod("RunEstimate: 34 p 3 - 5 / ")]
        public void RunEstimateTest1()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("34");
            arrayList.Add("p");
            arrayList.Add("3");
            arrayList.Add("-");
            arrayList.Add("5");
            arrayList.Add("/");

            AnalaizerClass.opz = arrayList;
            string actual = AnalaizerClass.RunEstimate();
            string expected = "6";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("RunEstimate: 34 p 3 - 0 / ")]
        public void RunEstimateTest2()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("34");
            arrayList.Add("p");
            arrayList.Add("3");
            arrayList.Add("-");
            arrayList.Add("0");
            arrayList.Add("/");

            AnalaizerClass.opz = arrayList;
            string actual = AnalaizerClass.RunEstimate();
            string expected = "Error 09";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("RunEstimate: 2147483500 m 2147483500 - 2 /")]
        public void RunEstimateTest3()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("2147483500");
            arrayList.Add("m");
            arrayList.Add("2147483500");
            arrayList.Add("-");
            arrayList.Add("2");
            arrayList.Add("/");

            AnalaizerClass.opz = arrayList;
            string actual = AnalaizerClass.RunEstimate();
            string expected = "Error 06";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("RunEstimate: 2147483648 m 2147483647 +")]
        public void RunEstimateTest4()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("2147483648");
            arrayList.Add("m");
            arrayList.Add("2147483647");
            arrayList.Add("+");

            AnalaizerClass.opz = arrayList;
            string actual = AnalaizerClass.RunEstimate();
            string expected = "-1";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("RunEstimate: 2147483646 m 2147483647 +")]
        public void RunEstimateTest5()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("2147483646");
            arrayList.Add("m");
            arrayList.Add("2147483647");
            arrayList.Add("+");

            AnalaizerClass.opz = arrayList;
            string actual = AnalaizerClass.RunEstimate();
            string expected = "1";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod("RunEstimate: 2147483645 m 2147483646")]
        public void RunEstimateTest6()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("2147483645");
            arrayList.Add("m");
            arrayList.Add("2147483646");

            AnalaizerClass.opz = arrayList;
            string actual = AnalaizerClass.RunEstimate();
            string expected = "Error 03";

            Assert.AreEqual(expected, actual);
        }
    }
}