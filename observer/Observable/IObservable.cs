using Observer.Observer;

namespace Observer.Observable
{
    public interface IObservable
    {
        public List<IObserver> Observers { get; set; }

        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
    }
}