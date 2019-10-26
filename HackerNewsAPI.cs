using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace API
{
    class HackerNewsAPI
    {

        private static string GetJsonString(string uri)
        {
            WebRequest request = WebRequest.Create(uri);
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(dataStream))
            {
                string responseFromServer = reader.ReadToEnd();
                return responseFromServer;
            }
        }
        public static JArray GetTopStories()
        {
            string topStoryString = GetJsonString("https://hacker-news.firebaseio.com/v0/topstories.json?print=pretty");
            return JArray.Parse(topStoryString);
        }
        public static ArticleObject GetArticle(int itemID)
        {
            JObject itemDetailsObject = JObject.Parse(GetJsonString($"https://hacker-news.firebaseio.com/v0/item/{itemID}.json?print=pretty"));
            ArticleObject article = new ArticleObject(itemDetailsObject);
            return article;
        }
    }
}


   