using NUnit.Framework;
using System;
using System.Threading;

namespace Lesson1.AutomationTesting
{
    [TestFixture]
    public class DependentTests
    {
        private int cartItems;

        [Test, Order(1)]
        public void CheckTitleWhenLoginUser()
        {
            // some login functionality
            Console.WriteLine("open shopping web page and do login");
            Assert.Pass("UserPage");
        }

        [Test, Order(2)]
        public void ShoppingCartShouldContain2ItemsOnMainPage()
        {
            cartItems = 2;
            Console.WriteLine("Add 2 items into shopping cart");
            Assert.That(cartItems==2);
        }

        [Test]
        public void ShoppingCartShouldContain2ItemsWhenOpenNewTab()
        {
            Console.WriteLine("Open New tab");
            Console.WriteLine("Open shopping web page");
            Assert.That(cartItems == 2);
        }

    }
}
