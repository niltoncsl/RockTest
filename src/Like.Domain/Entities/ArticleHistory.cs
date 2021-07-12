using System;
using System.Collections.Generic;
using System.Text;

namespace Like.Domain.Entities
{
    public class ArticleHistory
    {
        public int Id { get; set; }
        public int IdArticle { get; set; }
        public Article Article { get; set; }
        public DateTime DateCreation { get; set; }        
        public string Ip { get; set; }

        public ArticleHistory()
        {

        }
        public ArticleHistory(Article article, string ip)
        {
            this.Article = article;
            this.IdArticle = article.Id;
            this.DateCreation = DateTime.UtcNow;            
            this.Ip = ip;
        }
    }
}
