using System;

namespace Snake.Models
{
    public interface IGameManager
    {
        Guid CreateNewGameBoard(Size boardSize, ITimerManager timerManager);
        IGameBoard GetGameBoard(Guid id);
    }
}
