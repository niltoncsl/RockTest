using Like.Application.DTO.Response.Base;

namespace Like.Application.DTO.Response.Like
{
    public class ArticleResponse : BaseResponse
    {
        public int Id { get; set; }
        public int Total { get; set; }

        public ArticleResponse()
        {

        }
        public ArticleResponse(int id, int total)
        {
            this.Id = id;
            this.Total = total;
        }
    }
}
