namespace Observer.NewsObserver
{
    // Subject
    public interface INewsAgency
    {
        void Attach(ISubscriber subscriber);
        void Detach(ISubscriber subscriber);
        void Notify();
    }

}
