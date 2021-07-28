using System.Xml;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    internal sealed class ClientActionExecutionScopeStart : ClientAction
    {
        private ExecutionScope m_scope;

        public ExecutionScope Scope
        {
            get
            {
                return this.m_scope;
            }
        }

        public ClientActionExecutionScopeStart(ExecutionScope scope, string name) : base(scope.Context, null, name)
        {
            this.m_scope = scope;
        }

        internal override void WriteToXml(XmlWriter writer, SerializationContext serializationContext)
        {
        }
    }
}
