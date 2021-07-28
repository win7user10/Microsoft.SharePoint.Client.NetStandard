using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    //Edited for .NET Core
    //[Serializable]
    public class ClientRequestException : Exception
    {
        public ClientRequestException(string message) : base(message)
        {
        }

        public ClientRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }

        //Edited for .NET Core
        //protected ClientRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}
