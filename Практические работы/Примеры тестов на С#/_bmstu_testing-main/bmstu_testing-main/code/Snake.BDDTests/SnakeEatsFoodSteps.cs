using NUnit.Framework;
using Moq;
using System;
using System.Threading;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Snake.Models;
using Snake.Controllers;
using TechTalk.SpecFlow;

namespace Snake.BDDTests
{
    [Binding]
    public class SnakeEatFoodSteps
    {
        TimerCallback nextTurn = null;
        IGameManager gameManager;
        IGameBoard curGameBoard;
        GameController controller;
        Guid curGameGuid;

        [Given(@"gameboard was created")]
        public void GivenGameboardWasCreated()
        {
            gameManager = new GameManager();
            Mock<ITimerManager> mockTimer = new Mock<ITimerManager>();
            mockTimer.Setup(x => x.SetTimerCallbackDontStart(It.IsAny<TimerCallback>()))
                .Callback<TimerCallback>(r => nextTurn = r);
            controller = new GameController(gameManager);

            curGameGuid = gameManager.CreateNewGameBoard(new Size(5, 5), mockTimer.Object);
            E2ETests.E2ETests e2ETests = new E2ETests.E2ETests();
            curGameBoard = e2ETests.GetGameAndAssertIt(controller, curGameGuid);
        }
        
        [When(@"snake eats food")]
        public void WhenSnakeEatsFood()
        {
            E2ETests.E2ETests e2ETests = new E2ETests.E2ETests();
            List<EnumDirection> directions = e2ETests.GenerateDirectionsList(curGameBoard.Food[0], curGameBoard.Snake);
            Coordinate foodGoal = curGameBoard.Food[0];

            foreach (EnumDirection curDir in directions)
            {
                ActionResult patchResult = controller.PatchDirection(curGameGuid, new SnakeDirection() { Direction = curDir });
                Assert.IsInstanceOf<OkResult>(patchResult);

                nextTurn(null);
                curGameBoard = e2ETests.GetGameAndAssertIt(controller, curGameGuid);
            }
        }
        
        [Then(@"snake length should be (.*)")]
        public void ThenSnakeLengthShouldBe(int p0)
        {
            Assert.AreEqual(p0, curGameBoard.Snake.Count);
        }
    }
}
