namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class ServerUnauthorizedAccessException : ServerException
    {
        internal ServerUnauthorizedAccessException(string message, string serverStackTrace, int serverErrorCode, string serverErrorValue, string serverErrorTypeName, object serverErrorDetails, string serverErrorTraceCorrelationId) : base(message, serverStackTrace, serverErrorCode, serverErrorValue, serverErrorTypeName, serverErrorDetails, serverErrorTraceCorrelationId)
        {
        }
    }
}
