using Shared;

Console.WriteLine("Read One TouTube Channel!");

string url = "https://www.youtube.com/feeds/videos.xml?user=GoogleDevelopers";

ReadYouTube myClass = new ReadYouTube();

myClass.Read(url, 3);