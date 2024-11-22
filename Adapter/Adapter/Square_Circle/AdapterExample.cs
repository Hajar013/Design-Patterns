namespace Adapter.Problem
{
    class AdapterExample
    {
        public void Run()
        {
            LegacySorter legacySorter= new LegacySorter();
            // Let's add a couple circles to our Legacy Sorter.
            legacySorter.AddSortedItem(new Circle(5));
            legacySorter.AddSortedItem(new Circle(2));

            // Create our adaptee object.
            Square square = new Square(6);

            // Adapt our square to the iCircle interface.
            iCircle adaptedSquare = new SquareAdapter(square);

            // And finally, we can now add our square to the legacy item sorter.
            legacySorter.AddSortedItem(adaptedSquare);
        }
    }

}
