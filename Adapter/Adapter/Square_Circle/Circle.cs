namespace Adapter.Problem
{
    // Circle implements the iCircle interface
    class Circle : iCircle
    {
        int _radius;
        int iCircle.Radius => _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }
    }
}
