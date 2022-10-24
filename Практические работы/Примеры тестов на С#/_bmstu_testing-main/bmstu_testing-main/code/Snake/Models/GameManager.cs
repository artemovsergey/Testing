using System;
using System.Collections.Concurrent;

namespace Snake.Models
{
    public class GameManager : IGameManager
    {
        private ConcurrentDictionary<Guid, GameBoard> _gameBoards = new ConcurrentDictionary<Guid, GameBoard>();
        
        /// <summary>
        /// Создает новую игру с заданными параметрами
        /// </summary>
        /// <param name="boardSize">Размер поля</param>
        /// <param name="timerManager">Менеджер смены хода</param>
        public Guid CreateNewGameBoard(Size boardSize, ITimerManager timerManager)
        {
            GameBoard gameboard = new GameBoard(boardSize, timerManager);
            Guid id = Guid.NewGuid();
            while (!_gameBoards.TryAdd(id, gameboard))
                id = Guid.NewGuid();
            return id;
        }

        /// <summary>
        /// Возвращает игру по id
        /// </summary>
        public IGameBoard GetGameBoard(Guid id)
        {
            GameBoard _gameBoard;
            _gameBoards.TryGetValue(id, out _gameBoard);
            if (_gameBoard != null)
                _gameBoard.CountTimeUntilNextTurnMiliseconds();
            return _gameBoard;
        }
    }
}