using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    //Edited for .NET Core
    //[Serializable]
    public sealed class IdcrlException : Exception
    {
        public int ErrorCode
        {
            get
            {
                return base.HResult;
            }
        }

        public IdcrlException()
        {
        }

        public IdcrlException(string message) : base(message)
        {
        }

        public IdcrlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public IdcrlException(string message, int errorcode) : base(message)
        {
            base.HResult = errorcode;
        }

        //Edited for .NET Core
        //private IdcrlException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}
