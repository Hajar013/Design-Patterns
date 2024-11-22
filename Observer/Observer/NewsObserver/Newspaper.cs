using System;

namespace Observer.NewsObserver
{
    // ConcreteObserver
    public class Newspaper : ISubscriber
    {
        public void Update(string news)
        {
            Console.WriteLine($"Newspaper received news: {news}");
        }
    }

}
