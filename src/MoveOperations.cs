using System;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [Flags]
    public enum MoveOperations
    {
        None = 0,
        Overwrite = 1,
        AllowBrokenThickets = 8,
        BypassApprovePermission = 64
    }
}
