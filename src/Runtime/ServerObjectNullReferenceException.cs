using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    //Edited for .NET Core
    //[Serializable]
    public sealed class ServerObjectNullReferenceException : InvalidOperationException
    {
        public ServerObjectNullReferenceException() : base(Resources.GetString("ServerObjectIsNull"))
        {
        }

        public ServerObjectNullReferenceException(string message) : base(message)
        {
        }

        //Edited for .NET Core
        //private ServerObjectNullReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}

        public ServerObjectNullReferenceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
