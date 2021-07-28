namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public abstract class WebRequestExecutorFactory
    {
        public abstract WebRequestExecutor CreateWebRequestExecutor(ClientRuntimeContext context, string requestUrl);
    }
}