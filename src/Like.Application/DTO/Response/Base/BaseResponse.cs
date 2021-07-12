namespace Like.Application.DTO.Response.Base
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public BaseResponse()
        {
            this.Success = true;
        }

        public void Error(string message)
        {
            this.Success = false;
            this.Message = message;
        }
    }
}
