using Snake.Models;

namespace Snake.Tests.DataBuilder
{
    public class SizeBuilder
    {
        private Size _entity = new Size(0, 0);

        public SizeBuilder ZeroSize()
        {
            _entity = new Size(0, 0);
            return this;
        }

        public SizeBuilder MinSnakeFitSize()
        {
            _entity = new Size(1, 2);
            return this;
        }

        public SizeBuilder MinSnakeAndFoodFitSize()
        {
            _entity = new Size(1, 3);
            return this;
        }

        public SizeBuilder Box10x10()
        {
            _entity = new Size(10, 10);
            return this;
        }

        public SizeBuilder Box100x100()
        {
            _entity = new Size(100, 100);
            return this;
        }

        public Size Build()
        {
            return _entity;
        }
    }
}
