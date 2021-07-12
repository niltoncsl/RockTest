using Like.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Like.Domain.Interfaces.Repositories
{
    public interface IArticleRepository
    {
        Article GetById(int id);
        void Add(Article article);
        void Update(Article article);
    }
}
