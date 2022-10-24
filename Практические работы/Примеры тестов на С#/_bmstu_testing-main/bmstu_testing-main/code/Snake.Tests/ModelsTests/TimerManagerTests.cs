using System.Threading;
using NUnit.Framework;
using Snake.Models;

namespace Snake.Tests.ModelsTests
{
    class TimerManagerTests
    {
        TimerManager timerManager;
        private const int turnTime = 100;
        private const int delta = 25;
        private int _counter = 0;

        [SetUp]
        public void Init()
        {
            _counter = 0;
            timerManager = new TimerManager(turnTime);
            timerManager.SetTimerCallbackDontStart(IncCounter);
        }
        
        [TearDown]
        public void Dispose()
        {
            _counter = 0;
            timerManager.FinishTimer();
            timerManager = null;
        }

        /// <summary>
        /// Проверяет, что таймер не запустился до запуска
        /// </summary>
        [Test]
        public void CheckTimerDontRunUntilStartTest()
        {
            int timeMsWait = turnTime * 2;
            Thread.Sleep(timeMsWait);

            Assert.Zero(_counter);
        }

        /// <summary>
        /// Проверяет, что таймер запустился и
        /// отработал n раз после запуска
        /// </summary>
        [Test]
        [TestCase(10)]
        public void CheckTimerRunNTimesWhenStartedTest(int n)
        {
            int timeMsWait = turnTime * (n - 1) + delta;

            timerManager.StartTimer();
            Thread.Sleep(timeMsWait);

            Assert.AreEqual(n, _counter);
        }

        /// <summary>
        /// Проверяет, что таймер не
        /// отрабатывает досрочно
        /// </summary>
        [Test]
        public void CheckTimerDontIncSecondTImeIntilTimeoutTest()
        {
            int timeMsWait = turnTime / 2;
            timerManager.StartTimer();
            Thread.Sleep(timeMsWait);

            Assert.AreEqual(1, _counter);
        }

        private void IncCounter(object o)
        {
            _counter++;
        }
    }
}
