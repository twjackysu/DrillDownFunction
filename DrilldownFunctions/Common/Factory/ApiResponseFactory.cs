using DrilldownFunctions.Common.Error;
using DrilldownFunctions.Common.Response;

namespace DrilldownFunctions.Common.Factory
{
    public class ApiResponseFactory : IApiResponseFactory
    {
        public IApiResponse<T> CreateOKResponse<T>(T data)
        {
            return new ApiResponse<T>() { Data = data };
        }
        public IApiResponse<object> CreateErrorResponse(ErrorCodes code, string message = "")
        {
            return new ApiResponse<object>() { Error = new ErrorDetails(code, message) };
        }
    }
}
