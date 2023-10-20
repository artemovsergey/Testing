using NUnit.Framework;
using System;

namespace Lesson1.AutomationTesting
{
  
    public class AAAPatternExample
    {

       
        [Test]
        public void ShoppingCart_AddRemoveItems_CartContainsItems()
        {
            // Arrange
            Console.WriteLine("---Open web page www.shop.com---");

            // Act
            Console.WriteLine("---Add an item to cart---");
            Console.WriteLine("---Add another item to cart---");
            Console.WriteLine("---Add one more item to cart---");

            // Assert
            Assert.Pass("Cart contains 3 items");

            // Act
            Console.WriteLine("---Remove all items from cart---");

            // Assert
            Assert.Pass("Cart is empty");
        }


        [Test]
        public void ShoppingCart_AddItems_Corrected()
        {
            // Arrange
            Console.WriteLine("---Open web page www.shop.com---");

            // Act
            Console.WriteLine("---Add an item to cart---");
            Console.WriteLine("---Add another item to cart---");
            Console.WriteLine("---Add one more item to cart---");

            // Assert
            Assert.Pass("Cart contains 3 items");
        }

        [Test]
        public void ShoppingCart_RemoveItems_Corrected()
        {
            // Arrange
            Console.WriteLine("---Open web page www.shop.com---");

            // Подготовка 
            Console.WriteLine("---Add an item to cart---");
            Console.WriteLine("---Add another item to cart---");
            Console.WriteLine("---Add one more item to cart---");

            // Act
            Console.WriteLine("---Remove All items from cart---");

            // Assert
            Assert.Pass("Cart is empty");
        }
    }


}
