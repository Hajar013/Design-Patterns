namespace Adapter.Problem
{
    // Adapter that can adapt our square to the iCircle interface
    class SquareAdapter : iCircle
    {
        protected Square _square;
        public int Radius => _square.Width / 2;

        public SquareAdapter(Square square)
        {
            _square = square;
        }
    }
}
