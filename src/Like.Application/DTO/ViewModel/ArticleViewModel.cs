using System;
using System.Collections.Generic;
using System.Text;

namespace Like.Application.DTO.ViewModel
{
    public class ArticleViewModel
    {
        public int Total { get; set; }
        public int IdArticle { get; set; }
        public ArticleViewModel()
        {

        }
        public ArticleViewModel(int idArticle, int total)
        {
            Total = total;
            IdArticle = idArticle;
        }
    }
}
