using DrilldownFunctions.Common.Error;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrilldownFunctions.Common.Factory
{
    public interface IResponseFactory
    {
        IActionResult CreateOKResponse<T>(T data);
        IActionResult CreateErrorResponse(ErrorCodes code, string message = "", int statusCodes = StatusCodes.Status500InternalServerError);
    }
}
