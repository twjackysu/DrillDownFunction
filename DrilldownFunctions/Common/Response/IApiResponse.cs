using DrilldownFunctions.Common.Error;

namespace DrilldownFunctions.Common.Response
{
    public interface IApiResponse<T>
    {
        T Data { get; set; }
        ErrorDetails Error { get; set; }
    }
}
