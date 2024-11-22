using System.Collections.Generic;

namespace Observer.NewsObserver
{
    // ConcreteSubject
    public class NewsAgency : INewsAgency
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        private string _news;
        public void Attach(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }
        public void Detach(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }
        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(_news);
            }
        }
        public void ReleaseNews(string news)
        {
            _news = news;
            Notify();
        }
    }

}
