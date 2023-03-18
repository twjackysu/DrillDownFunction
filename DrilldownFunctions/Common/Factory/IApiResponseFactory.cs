using DrilldownFunctions.Common.Error;
using DrilldownFunctions.Common.Response;

namespace DrilldownFunctions.Common.Factory
{
    public interface IApiResponseFactory
    {
        IApiResponse<T> CreateOKResponse<T>(T data);
        IApiResponse<object> CreateErrorResponse(ErrorCodes code, string message = "");
    }
}
