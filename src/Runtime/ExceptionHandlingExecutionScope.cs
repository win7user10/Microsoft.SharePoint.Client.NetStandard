using System.Globalization;
using System.Xml;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    internal class ExceptionHandlingExecutionScope : ExecutionScope
    {
        private ExceptionHandlingScope m_scope;

        internal ExceptionHandlingExecutionScope(ClientRuntimeContext context, ExceptionHandlingScope scope, ExecutionScopeDisposingCallback callback) : base(context, "ExceptionHandlingScope", callback)
        {
            this.m_scope = scope;
        }

        internal override void WriteStart(XmlWriter writer, SerializationContext serializationContext)
        {
            if (this.m_scope.IsSimpleForm)
            {
                writer.WriteStartElement("ExceptionHandlingScopeSimple");
                writer.WriteAttributeString("Id", base.Id.ToString(CultureInfo.InvariantCulture));
                return;
            }
            base.WriteStart(writer, serializationContext);
        }
    }
}
