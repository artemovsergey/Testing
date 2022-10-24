using Snake.Models;

namespace Snake.Tests.DataBuilder
{
    class SnakeDirectionBuilder
    {
        private SnakeDirection _entity = new SnakeDirection();

        public SnakeDirectionBuilder IncorrectDirection()
        {
            _entity.Direction = (EnumDirection)111;
            return this;
        }

        public SnakeDirectionBuilder WhereDirection(EnumDirection direction)
        {
            _entity.Direction = direction;
            return this;
        }

        public SnakeDirectionBuilder LeftDirection()
        {
            _entity.Direction = EnumDirection.Left;
            return this;
        }

        public SnakeDirectionBuilder RightDirection()
        {
            _entity.Direction = EnumDirection.Right;
            return this;
        }

        public SnakeDirectionBuilder TopDirection()
        {
            _entity.Direction = EnumDirection.Top;
            return this;
        }

        public SnakeDirectionBuilder BottomDirection()
        {
            _entity.Direction = EnumDirection.Bottom;
            return this;
        }

        public SnakeDirection Build()
        {
            return _entity;
        }
    }
}
