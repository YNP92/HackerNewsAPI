using Newtonsoft.Json.Linq;
using System;

namespace API
{
    class ArticleObject 
    {
        private int id;
        private string title;
        private string url;
 
        public int ID
        {
            get {return id;}
            set {id = value;}
        }

        public string TITLE
        {
            get {return title;}
            set {title = value;}
        }

        public string URL
        {
            get { return url;}
            set { url = value;}
        }

        public ArticleObject(JObject itemDetailsObject)
        {
            ID = Convert.ToInt32(itemDetailsObject["id"]);
            TITLE = itemDetailsObject["title"].ToString();
            URL = itemDetailsObject["url"]?.ToString();
        }
    }
}