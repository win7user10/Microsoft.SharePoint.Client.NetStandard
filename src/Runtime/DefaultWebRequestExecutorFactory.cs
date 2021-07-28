using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    internal class DefaultWebRequestExecutorFactory : WebRequestExecutorFactory
    {
        public override WebRequestExecutor CreateWebRequestExecutor(ClientRuntimeContext context, string requestUrl)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (string.IsNullOrEmpty(requestUrl))
            {
                throw new ArgumentNullException("requestUrl");
            }
            return new SPWebRequestExecutor(context, requestUrl);
        }
    }
}
