namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public interface IScriptTypeFactory
    {
        IFromJson CreateObjectFromScriptType(string scriptTypeName, ClientRuntimeContext context);
    }
}
