using Like.Application.DTO.Response.Like;
using Like.Application.DTO.ViewModel;
using Like.Application.Interface;
using Like.Domain.Interfaces.Services;
using System;

namespace Like.Application.Services
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleService _articleService;
        public ArticleApplication(IArticleService articleService)
        {
            this._articleService = articleService;
        }

        public ArticleViewModel GetById(int idArticle)
        {
            var article = _articleService.GetById(idArticle);
            return new ArticleViewModel(article.Id, article.Total);
        }

        public ArticleResponse UpdateCounter(int idArticle, string ip)
        {
            var response = new ArticleResponse();
            try
            {                
                var article = _articleService.UpdateCounter(idArticle, ip);                
                response = new ArticleResponse(article.Id, article.Total);
            }
            catch (Exception ex)
            {
                response.Error(ex.Message);
            }            
            return response;
        }
    }
}
