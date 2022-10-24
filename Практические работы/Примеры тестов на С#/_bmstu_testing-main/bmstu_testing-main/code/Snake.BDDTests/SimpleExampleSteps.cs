using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Snake.BDDTests
{
    [Binding]
    public class SimpleExampleSteps
    {
        private int _number;

        [Given(@"I have a number: (\d+)")]
        public void GivenIHaveAShoppingCartWith(int n)
        {
            _number = n;
        }

        [When(@"I add (\d+) to the number")]
        public void WhenIPlaceIntoTheShoppingCart(int n)
        {
            _number += n;
        }

        [Then(@"my number should be (\d+)")]
        public void ThenMyShoppingCartShouldBeEmpty(int expected)
        {
            Assert.AreEqual(_number, expected);
        }
    }
}
