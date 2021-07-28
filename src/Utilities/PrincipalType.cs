using System;

namespace Microsoft.SharePoint.Client.NetStandard.Utilities
{
    [Flags]
    public enum PrincipalType
    {
        None = 0,
        User = 1,
        DistributionList = 2,
        SecurityGroup = 4,
        SharePointGroup = 8,
        All = 15
    }
}
