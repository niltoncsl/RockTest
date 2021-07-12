using Like.Domain.Dto;
using Like.Domain.Entities;
using Like.Domain.Interfaces.Repositories;
using Like.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Like.Domain.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleHistoryRepository _articleHistoryRepository;        
        public ArticleService(IArticleRepository articleRepository, IArticleHistoryRepository articleHistoryRepository)
        {
            _articleRepository = articleRepository;
            _articleHistoryRepository = articleHistoryRepository;
        }
        public Article GetById(int idArticle)
        {            
            return _articleRepository.GetById(idArticle);
        }

        public Article UpdateCounter(int idArticle, string ip)
        {
            var article = _articleRepository.GetById(idArticle);
            if (!_articleHistoryRepository.GetByArticleIp(idArticle, ip))
            {
                article.Total += 1;
                _articleRepository.Update(article);
                _articleHistoryRepository.Add(new ArticleHistory(article, ip));
            }
            return article;
        }
    }
}
