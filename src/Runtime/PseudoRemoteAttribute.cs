using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class PseudoRemoteAttribute : Attribute
    {
        public string Name
        {
            get;
            set;
        }
    }
}