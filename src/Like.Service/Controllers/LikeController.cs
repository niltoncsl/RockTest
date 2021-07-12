using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Like.Domain.Dto;
using Like.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Like.Service.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class LikeController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public LikeController(IArticleService articleService)
        {
            _articleService = likeService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public ActionResult<ResponseLike> GetLike(int idArticle)
        {
            var like = _articleService.GetLikeByIdArticle(idArticle);
            if (like == null)
            {
                return NotFound();
            }
            return Ok(like);
        }
        [HttpPut]
        public ActionResult<ResponseLike> UpdateCounter(int idArticle, string ip)
        {
            var like = _articleService.UpdateCounter(idArticle, ip);
            if (like == null)
            {
                return NotFound();
            }
            return Ok(like);
        }
    }
    
}
