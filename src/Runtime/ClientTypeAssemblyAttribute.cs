using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class ClientTypeAssemblyAttribute : Attribute
    {
        public Type ScriptTypeFactory
        {
            get;
            set;
        }
    }
}
