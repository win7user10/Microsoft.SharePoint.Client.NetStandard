using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    //Edited for .NET Core
    //[Serializable]
    public sealed class PropertyOrFieldNotInitializedException : InvalidOperationException
    {
        public PropertyOrFieldNotInitializedException() : base(Resources.GetString("PropertyHasNotBeenInitialized"))
        {
        }

        public PropertyOrFieldNotInitializedException(string message) : base(message)
        {
        }

        //Edited for .NET Core
        //private PropertyOrFieldNotInitializedException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}

        public PropertyOrFieldNotInitializedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}