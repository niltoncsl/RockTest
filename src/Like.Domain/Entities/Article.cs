using System;
using System.Collections.Generic;
using System.Text;

namespace Like.Domain.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public int Total { get; set; }
        public IList<ArticleHistory> ArticleHistory { get; set; }
    }
}
