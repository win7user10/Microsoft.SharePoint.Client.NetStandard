using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class RemoteAttribute : Attribute
    {
        public string Name
        {
            get;
            set;
        }
    }
}