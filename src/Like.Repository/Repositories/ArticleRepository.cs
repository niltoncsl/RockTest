using Like.Domain.Entities;
using Like.Domain.Interfaces.Repositories;
using Like.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Like.Repository.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly LikeContext _likeContext;
        public ArticleRepository(LikeContext likeContext)
        {
            this._likeContext = likeContext;
        }

        public void Add(Article article)
        {
            _likeContext.Add(article);
            _likeContext.SaveChanges();
        }

        public Article GetById(int id)
        {
            return _likeContext.Article.SingleOrDefault(s => s.Id == id);
        }

        public void Update(Article article)
        {
            _likeContext.Update(article);
            _likeContext.SaveChanges();
        }
    }
}
