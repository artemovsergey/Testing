using System.Threading;

namespace Snake.Models
{
    public interface ITimerManager
    {
        void StartTimer();
        void Reset();
        void FinishTimer();
        int CountTimeUntilNextTurnMiliseconds();
        void SetTimerCallbackDontStart(TimerCallback function);
    }
}
