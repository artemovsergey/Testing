using System.Threading;
using NUnit.Framework;
using Moq;
using Snake.Models;

namespace Snake.Tests.ModelsTests
{
    class GameBoardTests
    {
        IGameBoard gameBoard;
        TimerCallback nextTurn;
        Mock<ITimerManager> mockTimer;
        
        [SetUp]
        public void Init()
        {
            mockTimer = new Mock<ITimerManager>();
            mockTimer.Setup(x => x.SetTimerCallbackDontStart(It.IsAny<TimerCallback>()))
                .Callback<TimerCallback>(r => nextTurn = r);

            gameBoard = new GameBoard(new Size(20, 20), mockTimer.Object);
        }

        [TearDown]
        public void Dispose()
        {
            gameBoard = null;
            nextTurn = null;
            mockTimer = null;
        }

        /// <summary>
        /// Проверка, что при игра была создана успешно;
        /// установлен таймер
        /// </summary>
        [Test]
        public void CheckGameBoardTimerWasSetTest()
        {
            Assert.NotNull(gameBoard);
            mockTimer.Verify(x => x.SetTimerCallbackDontStart(It.IsAny<TimerCallback>()), Times.Once,
                "SetTimerFunction was not called once.");
        }

        /// <summary>
        /// Проверка, что доска обновляется
        /// </summary>
        [Test]
        public void CheckGameBoardAfterUpdateTest()
        {
            Coordinate[] snakeBody1 = gameBoard.Snake.ToArray();
            Coordinate[] snakeBody2 = gameBoard.Snake.ToArray();

            nextTurn(null);

            Assert.AreEqual(snakeBody1, snakeBody2);
            Assert.AreNotEqual(snakeBody1, gameBoard.Snake.ToArray());
            mockTimer.Verify(x => x.Reset(), Times.Once,
                "Turn was reset not once");
        }

        /// <summary>
        /// Проверка, что был совершен поворот налево
        /// </summary>
        [Test]
        public void CheckGameBoardAfterDirectionChangeTest()
        {
            Coordinate[] snakeBody1 = gameBoard.Snake.ToArray();

            gameBoard.ChangeSnakeDir(new SnakeDirection() { Direction = EnumDirection.Left });
            Coordinate[] snakeBody2 = gameBoard.Snake.ToArray();
            nextTurn(null);

            Assert.AreEqual(snakeBody1, snakeBody2);
            CheckThatSnakeTurnedLeft(snakeBody1, gameBoard.Snake.ToArray());
        }

        /// <summary>
        /// Проверка, что был совершен поворот налево
        /// при нескольких поворотах в один ход
        /// </summary>
        [Test]
        public void CheckGameBoardAfterMultipleDirectionChangeTest()
        {
            Coordinate[] snakeBody1 = gameBoard.Snake.ToArray();

            gameBoard.ChangeSnakeDir(new SnakeDirection() { Direction = EnumDirection.Right });
            gameBoard.ChangeSnakeDir(new SnakeDirection() { Direction = EnumDirection.Top });
            gameBoard.ChangeSnakeDir(new SnakeDirection() { Direction = EnumDirection.Left });
            nextTurn(null);
            
            CheckThatSnakeTurnedLeft(snakeBody1, gameBoard.Snake.ToArray());
        }

        /// <summary>
        /// Проверяем, что after - тело змейки before
        /// после поворота налево
        /// </summary>
        private void CheckThatSnakeTurnedLeft(Coordinate[] before, Coordinate[] after)
        {
            Coordinate first = new Coordinate(before[0].X - 1, before[0].Y);
            Assert.AreEqual(first, after[0]);

            for (int i = 0; i < before.Length - 1; i++)
                Assert.AreEqual(before[i], after[i + 1]);
        }
    }
}
