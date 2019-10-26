using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<ArticleObject> articleList = new List<ArticleObject>();

            foreach (int itemID in HackerNewsAPI.GetTopStories())
            {
                ArticleObject article = HackerNewsAPI.GetArticle(itemID);
                articleList.Add(article);
            }

            stopwatch.Stop();
            long runTime = stopwatch.ElapsedMilliseconds;

            Console.WriteLine(articleList[0].TITLE);
            Console.WriteLine("Run Time: " + runTime);
            Console.ReadLine();
        }
    }
}