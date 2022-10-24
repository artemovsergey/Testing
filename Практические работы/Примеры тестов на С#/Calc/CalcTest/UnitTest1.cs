using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calc;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Тест проверки метода AddWithInc
        /// </summary>
        [TestMethod]
        public void AddWithInc_2Plus3Inc1_Returned6()
        {
            // arrange 
            var calc = new Calculator(); // из проекта Calc
            double arg1 = 2;
            double arg2 = 3;
            double expected = 6;
            // act
            double result = calc.AddWithInc(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void Div_4Div2_Returned2()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 2;
            double expected = 2;
            // act
            double result = calc.Div(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),
    "Oh my god, we can't divison on zero")]
        public void Div_4Div0_ZeroDivException()
        {
            // arrange 
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 0;
            // act
            double result = calc.Div(arg1, arg2);
            // assert            
        }



    }
}
