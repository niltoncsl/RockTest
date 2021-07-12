using Like.Domain.Entities;
using Like.Domain.Interfaces.Repositories;
using Like.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Like.Repository.Repositories
{
    public class ArticleHistoryRepository : IArticleHistoryRepository
    {
        private readonly LikeContext _likeContext;
        public ArticleHistoryRepository(LikeContext likeContext)
        {
            this._likeContext = likeContext;
        }

        public void Add(ArticleHistory articleHistory)
        {
            _likeContext.Add(articleHistory);
            _likeContext.SaveChanges();
        }

        public bool GetByArticleIp(int idArticle, string ip)
        {
            return _likeContext.ArticleHistory.Any(a => a.IdArticle == idArticle && ip.Equals(ip));
        }

        public ArticleHistory GetById(int id)
        {
            return _likeContext.ArticleHistory.SingleOrDefault(s => s.Id == id);
        }

        public void Update(ArticleHistory articleHistory)
        {
            _likeContext.Update(articleHistory);
            _likeContext.SaveChanges();
        }
    }
}
