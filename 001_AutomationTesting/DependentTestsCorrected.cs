using NUnit.Framework;
using System;

namespace Lesson1.AutomationTesting
{
    [TestFixture]
    public class DependentTestsCorrected
    {
        private int cartItems;

        [SetUp]
        public void Initialization()
        {
            Console.WriteLine("open shopping web page and do login");
            cartItems = 2;
            Console.WriteLine("Add 2 items into shopping cart");

        }

        [Test]
        public void CheckTitleWhenLoginUser()
        {
            // some login functionality
            Assert.Pass("UserPage");
        }

        [Test]
        public void ShoppingCartShouldContain2ItemsOnMainPage()
        {
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
