using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class WebRequestEventArgs : EventArgs
    {
        private WebRequestExecutor m_webRequestExecutor;

        public WebRequestExecutor WebRequestExecutor
        {
            get
            {
                return this.m_webRequestExecutor;
            }
        }

        public WebRequestEventArgs(WebRequestExecutor webRequestExecutor)
        {
            if (webRequestExecutor == null)
            {
                throw new ArgumentNullException("webRequestExecutor");
            }
            this.m_webRequestExecutor = webRequestExecutor;
        }
    }
}
