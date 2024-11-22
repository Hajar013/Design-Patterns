namespace Adapter.Problem
{
    // Our adaptee that is incompatible with the iCircle interface
    class Square
    {
        public int Width { get; private set; }
        public Square(int width)
        {
            Width = width;
        }
    }

}
