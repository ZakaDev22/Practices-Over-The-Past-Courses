using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Event_Example
{

    public class NewsArticle
    {
        public string Content { get; set; }

        public string Title { get; set; }



      public    NewsArticle( string Title, string content)
        {
            this.Title = Title;
            this.Content = content;
        }
    }

    public class clsPublisher
    {
        public event EventHandler<NewsArticle> NewNewsPubleshed;

        public void PubleshNews(string Title, string Content)

        {
            var Article = new NewsArticle(Title, Content);
            OnNewNewPublished(Article);
        }

        public void OnNewNewPublished(NewsArticle Article)
        {
            NewNewsPubleshed?.Invoke(this, Article);
        }
    }
}
