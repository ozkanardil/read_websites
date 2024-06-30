using System.ServiceModel.Syndication;
using System.Xml;

namespace Shared
{
    public class ReadYouTube
    {
        public void Read(string url, int daysBefore)
        {
            using var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);

            DateTime yesterday = DateTime.Now.Subtract(TimeSpan.FromDays(daysBefore));

            if (feed == null)
            {
                Console.WriteLine("No video found!");
            }
            else
            {
                foreach (var post in feed.Items)
                {
                    if (post.PublishDate > yesterday)
                    {
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine("Title: " + post.Title.Text);
                        Console.WriteLine("Link: " + post.Links[0].Uri.AbsoluteUri);
                        Console.WriteLine("PublishDate: " + post.PublishDate);
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
