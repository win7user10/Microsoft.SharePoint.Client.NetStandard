using System;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [Flags]
    public enum CustomizedPageStatus
    {
        None = 0,
        Uncustomized = 1,
        Customized = 2
    }
}
