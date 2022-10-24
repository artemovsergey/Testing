using System;
using Moq;
using NUnit.Framework;
using Snake.Models;
using Snake.Tests.DataBuilder;

namespace Snake.Tests.ModelsTests
{
    class GameManagerTests
    {
        IGameManager gameManager;

        [SetUp]
        public void Init()
        {
            gameManager = new GameManager();
        }

        [TearDown]
        public void Dispose()
        {
            gameManager = null;
        }

        /// <summary>
        /// Проверяет создание новой доски
        /// </summary>
        [Test]
        [Timeout(5000)] // 5 секунд
        public void CreateNewGameBoardNotEmptyTest()
        {
            Mock<ITimerManager> timerManager = new Mock<ITimerManager>();
            Size size = new SizeBuilder().Box10x10().Build();

            Guid resGuid = gameManager.CreateNewGameBoard(size, timerManager.Object);
            
            Assert.AreNotEqual(resGuid, Guid.Empty);
        }

        /// <summary>
        /// Проверяет что две созданные доски имеют разные Guid
        /// </summary>
        [Test]
        [Timeout(10000)] // 5 секунд
        public void TestTwoCreatedBoardsDifferentGuidTest()
        {
            Mock<ITimerManager> timerManager1 = new Mock<ITimerManager>();
            Mock<ITimerManager> timerManager2 = new Mock<ITimerManager>();
            Size size = new SizeBuilder().Box10x10().Build();

            Guid gameGuid1 = gameManager.CreateNewGameBoard(size, timerManager1.Object);
            Guid gameGuid2 = gameManager.CreateNewGameBoard(size, timerManager2.Object);
            
            Assert.AreNotEqual(gameGuid1, gameGuid2);
        }
        
        /// <summary>
        /// Проверяет получение созданной доски
        /// </summary>
        [Test]
        [Timeout(5000)] // 5 секунд
        public void GetCreatedGameboardNotNullTest()
        {
            Mock<ITimerManager> timerManager = new Mock<ITimerManager>();
            Size size = new SizeBuilder().Box10x10().Build();
            Guid gameGuid = gameManager.CreateNewGameBoard(size, timerManager.Object);

            IGameBoard gameBoard = gameManager.GetGameBoard(gameGuid);

            Assert.NotNull(gameBoard);
        }

        /// <summary>
        /// Проверяет что полученные две доски разные
        /// </summary>
        [Test]
        [Timeout(10000)]
        public void TwoGameboardsAreDifferentTest()
        {
            Mock<ITimerManager> timerManager1 = new Mock<ITimerManager>();
            Mock<ITimerManager> timerManager2 = new Mock<ITimerManager>();
            Size size = new SizeBuilder().Box10x10().Build();
            Guid gameGuid1 = gameManager.CreateNewGameBoard(size, timerManager1.Object);
            Guid gameGuid2 = gameManager.CreateNewGameBoard(size, timerManager2.Object);

            IGameBoard gameBoard1 = gameManager.GetGameBoard(gameGuid1);
            IGameBoard gameBoard2 = gameManager.GetGameBoard(gameGuid2);

            Assert.NotNull(gameBoard1);
            Assert.NotNull(gameBoard2);
            Assert.AreNotEqual(gameBoard1, gameBoard2);
        }

        /// <summary>
        /// Проверяет что после создания второй доски, первая не изменилась
        /// </summary>
        [Test]
        [Timeout(10000)]
        public void AfterSecondGameCreationFirstIsSameTest()
        {
            Mock<ITimerManager> timerManager1 = new Mock<ITimerManager>();
            Mock<ITimerManager> timerManager2 = new Mock<ITimerManager>();
            Size size = new SizeBuilder().Box10x10().Build();
            Guid gameGuid1 = gameManager.CreateNewGameBoard(size, timerManager1.Object);
            IGameBoard gameBoard11 = gameManager.GetGameBoard(gameGuid1);

            Guid gameGuid2 = gameManager.CreateNewGameBoard(size, timerManager2.Object);

            IGameBoard gameBoard12 = gameManager.GetGameBoard(gameGuid1);
            Assert.AreEqual(gameBoard11, gameBoard12);
        }
    }
}
