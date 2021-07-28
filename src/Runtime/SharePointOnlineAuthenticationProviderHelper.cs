using Microsoft.SharePoint.Client.NetStandard.Idcrl;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    internal static class SharePointOnlineAuthenticationProviderHelper
    {
        internal static ISharePointOnlineAuthenticationProvider CreateDefaultProvider()
        {
            return new SharePointOnlineAuthenticationProvider();
        }
    }
}
