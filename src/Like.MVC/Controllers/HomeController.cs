using Like.Application.DTO.Response.Like;
using Like.Application.DTO.ViewModel;
using Like.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Like.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleApplication _likeApplication;
        const int ID_ARTICLE = 1;

        public HomeController(ILogger<HomeController> logger, IArticleApplication likeApplication)
        {
            _logger = logger;
            _likeApplication = likeApplication;
        }

        public IActionResult Index()
        {
            var article = _likeApplication.GetById(ID_ARTICLE);
            return View(article);
        }
        [HttpPost]
        public ArticleResponse Update(int idArticle)
        {            
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            var response = _likeApplication.UpdateCounter(ID_ARTICLE, ip);
            return response;
        }
    }
}
