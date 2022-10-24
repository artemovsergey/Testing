using System;
using System.Diagnostics;
using System.Threading;

namespace Snake.Models
{
    /// <summary>
    /// Отвечает за запуск функции по таймеру и 
    /// взаимодействие со временем связанным с таймером
    /// </summary>
    public class TimerManager : ITimerManager
    {
        private TimeSpan _turnTime;
        private Timer _onUpdateTimer;        
        private Stopwatch _stopwatch;
        
        /// <summary>
        /// Менеджер для периодично запускаемой function
        /// </summary>
        /// <param name="turnTimeInMilliseconds">Периодичность запуска</param>
        public TimerManager(int turnTimeInMilliseconds)
        {
            _turnTime = new TimeSpan(0, 0, 0, 0, turnTimeInMilliseconds);
            _stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Устанавливает периодично запускаемую функцию
        /// </summary>
        /// <param name="function">Периодично запускаемая функция</param>
        public void SetTimerCallbackDontStart(TimerCallback function)
        {
            if (_onUpdateTimer != null)
                _onUpdateTimer.Dispose();
            _onUpdateTimer = new Timer(function);
        }

        /// <summary>
        /// Запуск таймера
        /// </summary>
        public void StartTimer()
        {
            _stopwatch.Reset();
            _stopwatch.Start();
            _onUpdateTimer.Change(0, (int)_turnTime.TotalMilliseconds); // запуск периодичного function
        }

        /// <summary>
        /// Перезапуск часов
        /// </summary>
        public void Reset()
        {
            _stopwatch.Reset();
            _stopwatch.Start();
        }

        /// <summary>
        /// Заканчивает жизненный цикл таймера
        /// </summary>
        public void FinishTimer()
        {
            // Чтобы был действительно новый таймер при
            // малых интервалах создания (когда GC не поспевает)
            _onUpdateTimer.Dispose();
        }

        /// <summary>
        /// Возвращает время до наступления следующего хода
        /// </summary>
        public int CountTimeUntilNextTurnMiliseconds()
        {
            TimeSpan remainingTime = _turnTime.Subtract(_stopwatch.Elapsed);
            return (int)remainingTime.TotalMilliseconds;
        }
    }
}