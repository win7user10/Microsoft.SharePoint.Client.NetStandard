using System;
using System.Net;
using Microsoft.SharePoint.Client.NetStandard.Application;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
  internal class SharePointOnlineAuthenticationModule : ISharePointOnlineAuthenticationModule
  {
        private const string EmptyAuthorization = " ";

        private static object s_lock = new object();

        private static SharePointOnlineAuthenticationModule s_instance;

        public string AuthenticationType
        {
            get
            {
                return "SPOIDCRL";
            }
        }

        public bool CanPreAuthenticate
        {
            get
            {
                return true;
            }
        }

        private SharePointOnlineAuthenticationModule()
        {
        }

        public SharePointAuthorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
        {
            SharePointOnlineCredentials sharePointOnlineCredentials = credentials as SharePointOnlineCredentials;
            if (sharePointOnlineCredentials != null && this.GetSpoAuthCookieAndUpdateRequest(request, sharePointOnlineCredentials, false))
            {
                return new SharePointAuthorization(" ");
            }
            return null;
        }

        public SharePointAuthorization PreAuthenticate(WebRequest request, ICredentials credentials)
        {
            SharePointOnlineCredentials sharePointOnlineCredentials = credentials as SharePointOnlineCredentials;
            if (sharePointOnlineCredentials != null)
            {
                this.GetSpoAuthCookieAndUpdateRequest(request, sharePointOnlineCredentials, true);
            }
            return null;
        }

        private bool GetSpoAuthCookieAndUpdateRequest(WebRequest request, SharePointOnlineCredentials spoCredentials, bool preAuthentication)
        {
            string text = request.RequestUri.ToString();
            int num = text.IndexOf('?');
            if (num > 0)
            {
                text = text.Substring(0, num);
            }
            num = text.IndexOf('#');
            if (num > 0)
            {
                text = text.Substring(0, num);
            }
            num = text.IndexOf("/_vti_bin", StringComparison.OrdinalIgnoreCase);
            if (num > 0)
            {
                text = text.Substring(0, num);
            }
            num = text.IndexOf("/_api", StringComparison.OrdinalIgnoreCase);
            if (num > 0)
            {
                text = text.Substring(0, num);
            }
            Uri url = new Uri(text);
            string authenticationCookie;
            if (preAuthentication)
            {
                authenticationCookie = spoCredentials.GetAuthenticationCookie(url, false, true);
                if (string.IsNullOrEmpty(authenticationCookie))
                {
                    authenticationCookie = spoCredentials.GetAuthenticationCookie(url, true, true);
                }
            }
            else
            {
                authenticationCookie = spoCredentials.GetAuthenticationCookie(url, true, true);
            }
            if (!string.IsNullOrEmpty(authenticationCookie))
            {
                request.Headers[HttpRequestHeader.Cookie] = authenticationCookie;
                return true;
            }
            return false;
        }

        internal static void EnsureRegistered()
        {
            if (SharePointOnlineAuthenticationModule.s_instance == null)
            {
                lock (SharePointOnlineAuthenticationModule.s_lock)
                {
                    if (SharePointOnlineAuthenticationModule.s_instance == null)
                    {
                        SharePointOnlineAuthenticationModule.s_instance = new SharePointOnlineAuthenticationModule();
                        //Edited for .NET Core
                        //AuthenticationManager.Register(SharePointOnlineAuthenticationModule.s_instance);
                    }
                }
            }
        }
    }
}
