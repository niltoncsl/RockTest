using Like.Application.DTO.Response.Like;
using Like.Application.DTO.ViewModel;

namespace Like.Application.Interface
{
    public interface IArticleApplication
    {
        ArticleViewModel GetById(int idArticle);
        ArticleResponse UpdateCounter(int idArticle, string ip);
    }
}
