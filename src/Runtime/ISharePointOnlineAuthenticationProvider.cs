using System;
using System.Security;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    internal interface ISharePointOnlineAuthenticationProvider
    {
        string GetAuthenticationCookie(Uri url, string userName, SecureString password, bool alwaysThrowOnFailure, EventHandler<SharePointOnlineCredentialsWebRequestEventArgs> executingWebRequest);
    }
}
