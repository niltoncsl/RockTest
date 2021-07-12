using Like.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Like.Domain.Interfaces.Repositories
{
    public interface IArticleHistoryRepository
    {
        bool GetByArticleIp(int idArticle, string ip);
        void Add(ArticleHistory articleHistory);
    }
}
