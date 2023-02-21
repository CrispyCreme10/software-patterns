using Observer.Observable.Concrete;

namespace Observer.Observer.Concrete
{
    public class MobileAppViewer : IObserver
    {
        public NewsFeed NewsFeed { get; set; }
        public int Id { get; set; }

        public MobileAppViewer(int id, NewsFeed newsFeed)
        {
            Id = id;
            NewsFeed = newsFeed;
        }

        public void Update()
        {
            System.Console.WriteLine($"{nameof(MobileAppViewer)}{Id} has received news feed update of {NewsFeed.Feed}");
        }
    }
}