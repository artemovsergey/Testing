using NUnit.Framework;
using Snake.Models;
using Snake.Tests.DataBuilder;

namespace Snake.Tests.ModelsTests
{
    class DirectionTests
    {
        /// <summary>
        /// Проверяет метод IsDirectionOk на некорректных данных
        /// </summary>
        [Test]
        public void IncorrectDirectionTest()
        {
            SnakeDirection direction = new SnakeDirectionBuilder().IncorrectDirection().Build();
            Assert.False(direction.IsDirectionOk());
        }
        
        /// <summary>
        /// Проверяет метод IsDirectionOk на корретных данных
        /// </summary>
        [TestCase(EnumDirection.Left)]
        [TestCase(EnumDirection.Right)]
        [TestCase(EnumDirection.Top)]
        [TestCase(EnumDirection.Bottom)]
        public void CorrectDirectionTest(EnumDirection dir)
        {
            SnakeDirection direction = new SnakeDirectionBuilder().WhereDirection(dir).Build();
            Assert.True(direction.IsDirectionOk());
        }
        
        /// <summary>
        /// Проверяет метод IsDirectionsContrary на обратных направлениях
        /// </summary>
        [TestCase(EnumDirection.Left, EnumDirection.Right)]
        [TestCase(EnumDirection.Top, EnumDirection.Bottom)]
        public void ContraryDirectionTest(EnumDirection firstDir, EnumDirection contraryDir)
        {
            SnakeDirection direction = new SnakeDirectionBuilder().WhereDirection(firstDir).Build();
            SnakeDirection contraryDirection = new SnakeDirectionBuilder().WhereDirection(contraryDir).Build();
            Assert.True(direction.IsDirectionsContrary(contraryDirection));
            Assert.True(contraryDirection.IsDirectionsContrary(direction));
        }
        
        /// <summary>
        /// Проверяет метод IsDirectionsContrary на одинаковых направлениях
        /// </summary>
        [Test]
        public void SameDirectionTest()
        {
            SnakeDirection direction = new SnakeDirectionBuilder().LeftDirection().Build();
            Assert.False(direction.IsDirectionsContrary(direction));
        }
        
        /// <summary>
        /// Проверяет метод IsDirectionsContrary на разных, не обратных направлениях
        /// </summary>
        [TestCase(EnumDirection.Top, EnumDirection.Left)]
        [TestCase(EnumDirection.Top, EnumDirection.Right)]
        [TestCase(EnumDirection.Left, EnumDirection.Bottom)]
        [TestCase(EnumDirection.Right, EnumDirection.Bottom)]
        public void NonContraryDirectionTest(EnumDirection firstDir, EnumDirection nonContraryDir)
        {
            SnakeDirection direction = new SnakeDirectionBuilder().WhereDirection(firstDir).Build();
            SnakeDirection nonContraryDirection = new SnakeDirectionBuilder().WhereDirection(nonContraryDir).Build();
            Assert.False(direction.IsDirectionsContrary(nonContraryDirection));
            Assert.False(nonContraryDirection.IsDirectionsContrary(direction));
        }
    }
}
