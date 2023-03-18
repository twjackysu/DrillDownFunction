using DrilldownFunctions.Common.Error;

namespace DrilldownFunctions.Common.Response
{
    public class ApiResponse<T> : IApiResponse<T>
    {
        public T Data { get; set; }
        public ErrorDetails Error { get; set; }
    }
}
