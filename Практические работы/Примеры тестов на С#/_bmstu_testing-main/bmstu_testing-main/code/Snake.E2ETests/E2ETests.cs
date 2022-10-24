using NUnit.Framework;
using Moq;
using System;
using System.Threading;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Snake.Models;
using Snake.Controllers;

namespace Snake.E2ETests
{
    public class E2ETests
    {
        [TestCase(100)]
        public void UserScenarioNTimesTest(int n)
        {
            for (int i = 0; i < n; i++)
                UserScenario();
        }
        
        public void UserScenario()
        {
            // ----- Создание игры -----
            // Arrange
            TimerCallback nextTurn = null;
            IGameManager gameManager = new GameManager();
            Mock<ITimerManager> mockTimer = new Mock<ITimerManager>();
            mockTimer.Setup(x => x.SetTimerCallbackDontStart(It.IsAny<TimerCallback>()))
                .Callback<TimerCallback>(r => nextTurn = r);
            GameController controller = new GameController(gameManager);

            // Act: создание новой игры
            Guid curGameGuid = gameManager.CreateNewGameBoard(new Size(5, 5), mockTimer.Object);

            // Act, Assert
            IGameBoard gameBoard = GetGameAndAssertIt(controller, curGameGuid);

            // ----- Попытка съесть еду -----
            List<EnumDirection> directions = GenerateDirectionsList(gameBoard.Food[0], gameBoard.Snake);
            int initialSize = gameBoard.Snake.Count;
            Coordinate foodGoal = gameBoard.Food[0];
            
            foreach (EnumDirection curDir in directions)
            {
                ActionResult patchResult = controller.PatchDirection(curGameGuid, new SnakeDirection() { Direction = curDir });
                Assert.IsInstanceOf<OkResult>(patchResult);

                nextTurn(null);
                gameBoard = GetGameAndAssertIt(controller, curGameGuid);
                Coordinate curFood = gameBoard.Food[0];
                if (!foodGoal.Equals(gameBoard.Snake[0]))
                    Assert.True(foodGoal.Equals(curFood), 
                        $"Food goal moved.\n" +
                        $"Expected: ({ foodGoal.X };{ foodGoal.Y })\n" +
                        $"But was: ({ curFood.X };{ curFood.Y })"); // еда не сдвинулась пока не съели
            }

            // Assert: размер змейки увеличился
            Assert.AreEqual(initialSize + 1, gameBoard.Snake.Count);
        }

        public IGameBoard GetGameAndAssertIt(GameController controller, Guid curGameGuid)
        {
            // Act: получить созданную игру
            ActionResult getCreatedGame = controller.GetGameboard(curGameGuid);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(getCreatedGame);
            IGameBoard gameBoard = (IGameBoard)((OkObjectResult)getCreatedGame).Value;
            Assert.IsNotEmpty(gameBoard.Food);
            Assert.IsNotEmpty(gameBoard.Snake);

            return gameBoard;
        }

        /// <summary>
        /// Предполагается, что змейка смотрит вверх
        /// </summary>
        public List<EnumDirection> GenerateDirectionsList(Coordinate food, List<Coordinate> body)
        {
            Coordinate head = body[0];
            List<EnumDirection> directions = new List<EnumDirection>();

            if (food.Y <= head.Y) // еда выше головы
            {
                AddNDirectionsToList(directions, EnumDirection.Top, head.Y - food.Y);
                if (food.X > head.X)
                    AddNDirectionsToList(directions, EnumDirection.Right, food.X - head.X);
                else
                    AddNDirectionsToList(directions, EnumDirection.Left, head.X - food.X);
            }
            else
            {
                directions.Add(EnumDirection.Right);
                directions.Add(EnumDirection.Bottom);
                AddNDirectionsToList(directions, EnumDirection.Bottom, food.Y - head.X - 1);
                if (food.X > head.X)
                    AddNDirectionsToList(directions, EnumDirection.Right, food.X - head.X - 1);
                else
                    AddNDirectionsToList(directions, EnumDirection.Left, head.X - food.X + 1);
            }

            return directions;
        }

        public void AddNDirectionsToList(List<EnumDirection> directions, EnumDirection direction, int n)
        {
            for (int i = 0; i < n; i++)
                directions.Add(direction);
        }
    }
}