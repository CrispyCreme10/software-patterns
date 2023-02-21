using Observer.Observer;

namespace Observer.Observable.Concrete
{
    public class NewsFeed : IObservable
    {
        public List<IObserver> Observers { get; set; } = new List<IObserver>();
        public string Feed { get; set; } = "*initial feed*";

        public void Add(IObserver observer)
        {
            if(!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
        }

        public void Remove(IObserver observer)
        {
            if(Observers.Contains(observer))
            {
                Observers.Remove(observer);
            }
        }

        public void Notify()
        {
            Observers.ForEach(obs => obs.Update());
        }

        public void Run()
        {
            Thread.Sleep(2000);
            Feed = "Urgent Update!";
            Notify();
            Thread.Sleep(5000);
            Feed = "New News!";
            Notify();
        }
    }
}