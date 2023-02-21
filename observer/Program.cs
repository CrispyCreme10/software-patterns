using Observer.Observable.Concrete;
using Observer.Observer.Concrete;

// Setup
var newsFeed = new NewsFeed();

var webViewer = new WebViewer(1, newsFeed);
var webViewer2 = new WebViewer(2, newsFeed);

var appViewer = new MobileAppViewer(3, newsFeed);
var appViewer2 = new MobileAppViewer(4, newsFeed);

newsFeed.Add(webViewer);
newsFeed.Add(webViewer2);
newsFeed.Add(appViewer);
newsFeed.Add(appViewer2);

// Example run
newsFeed.Run();
