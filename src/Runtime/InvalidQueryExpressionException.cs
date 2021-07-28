using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    //Edited for .NET Core
    //[Serializable]
    public sealed class InvalidQueryExpressionException : ClientRequestException
    {
        public InvalidQueryExpressionException() : base(Resources.GetString("NotSupportedQueryExpression"))
        {
        }

        public InvalidQueryExpressionException(string message) : base(message)
        {
        }

        public InvalidQueryExpressionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        //Edited for .NET Core
        //private InvalidQueryExpressionException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}
