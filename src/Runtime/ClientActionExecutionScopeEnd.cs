using System.Xml;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    internal sealed class ClientActionExecutionScopeEnd : ClientAction
    {
        private ExecutionScope m_scope;

        public ExecutionScope Scope
        {
            get
            {
                return this.m_scope;
            }
        }

        public ClientActionExecutionScopeEnd(ExecutionScope scope, string name) : base(scope.Context, null, name)
        {
            this.m_scope = scope;
        }

        internal override void WriteToXml(XmlWriter writer, SerializationContext serializationContext)
        {
        }
    }
}
