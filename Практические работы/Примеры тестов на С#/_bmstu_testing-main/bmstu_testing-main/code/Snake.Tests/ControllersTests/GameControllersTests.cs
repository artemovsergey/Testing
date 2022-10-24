using NUnit.Framework;
using Moq;
using System;
using Microsoft.AspNetCore.Mvc;
using Snake.Models;
using Snake.Controllers;

namespace Snake.Tests.ControllersTests
{
    public class GameControllerTests
    {
        Mock<IGameManager> mockGameManager;
        GameController controller;
        Guid curGameGuid;

        [SetUp]
        public void Init()
        {
            curGameGuid = Guid.NewGuid();
            mockGameManager = new Mock<IGameManager>();
        }

        [TearDown]
        public void Dispose()
        {
            mockGameManager = null;
            controller = null;
            curGameGuid = Guid.Empty;
        }

        /// <summary>
        /// Проверяет создание игры
        /// </summary>
        [Test]
        public void CreateGameTest()
        {
            mockGameManager.Setup(x => x.CreateNewGameBoard(It.IsAny<Size>(), It.IsAny<ITimerManager>()))
                .Returns(curGameGuid);
            controller = new GameController(mockGameManager.Object);

            ActionResult actionResult = controller.GetGameboard();

            Assert.IsInstanceOf<OkObjectResult>(actionResult);
            Assert.AreEqual(curGameGuid, (Guid)((OkObjectResult)actionResult).Value);
        }

        /// <summary>
        /// Проверяет получение существующей игры
        /// </summary>
        [Test]
        public void GetExistingGameboard()
        {
            Mock<IGameBoard> mockResGB = new Mock<IGameBoard>();
            mockGameManager.Setup(x => x.GetGameBoard(curGameGuid))
                .Returns(mockResGB.Object);
            controller = new GameController(mockGameManager.Object);

            ActionResult actionResult = controller.GetGameboard(curGameGuid);

            Assert.IsInstanceOf<OkObjectResult>(actionResult);
            Assert.AreEqual(mockResGB.Object, (IGameBoard)((OkObjectResult)actionResult).Value);
        }

        /// <summary>
        /// Проверяет получение не существующей игры
        /// </summary>
        [Test]
        public void GetNotExistingGameboard()
        {
            mockGameManager.Setup(x => x.GetGameBoard(curGameGuid))
                .Returns<IGameBoard>(null);
            controller = new GameController(mockGameManager.Object);

            ActionResult actionResult = controller.GetGameboard(curGameGuid);

            Assert.IsInstanceOf<NotFoundResult>(actionResult);
        }
    }
}
