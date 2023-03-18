using DrilldownFunctions.Common.Error;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrilldownFunctions.Common.Factory
{
    public class ResponseFactory : IResponseFactory
    {
        private readonly IApiResponseFactory _apiResponseFactory;
        public ResponseFactory(IApiResponseFactory apiResponseFactory)
        {
            _apiResponseFactory = apiResponseFactory;
        }
        public IActionResult CreateOKResponse<T>(T data)
        {
            return new OkObjectResult(_apiResponseFactory.CreateOKResponse(data));
        }
        public IActionResult CreateErrorResponse(ErrorCodes code, string message = "", int statusCodes = StatusCodes.Status500InternalServerError)
        {
            return new ObjectResult(_apiResponseFactory.CreateErrorResponse(code, message))
            {
                StatusCode = statusCodes
            };
        }
    }
}
