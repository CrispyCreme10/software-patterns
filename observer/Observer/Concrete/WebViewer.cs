using Observer.Observable.Concrete;

namespace Observer.Observer.Concrete
{
    public class WebViewer : IObserver
    {
        public NewsFeed NewsFeed { get; set; }
        public int Id { get; set; }

        public WebViewer(int id, NewsFeed newsFeed)
        {
            Id = id;
            NewsFeed = newsFeed;
        }

        public void Update()
        {
            System.Console.WriteLine($"{nameof(WebViewer)}{Id} has received news feed update of {NewsFeed.Feed}");
        }
    }
}