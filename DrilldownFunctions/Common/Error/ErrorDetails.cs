namespace DrilldownFunctions.Common.Error
{
    public class ErrorDetails
    {
        public ErrorDetails(ErrorCodes code, string message)
        {
            Code = code;
            Message = message;
        }
        public ErrorCodes Code { get; set; }
        public string Message { get; set; }
    }
}
