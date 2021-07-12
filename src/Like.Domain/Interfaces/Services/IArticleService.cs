using Like.Domain.Entities;

namespace Like.Domain.Interfaces.Services
{
    public interface IArticleService
    {
        Article GetById(int idArticle);
        Article UpdateCounter(int idArticle, string ip);
    }
}
