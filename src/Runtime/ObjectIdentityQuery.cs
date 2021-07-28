using System.Globalization;
using System.Xml;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public sealed class ObjectIdentityQuery : ClientAction
    {
        public ObjectIdentityQuery(ObjectPath objectPath) : base(ClientRuntimeContext.GetContextFromObjectPath(objectPath), objectPath, null)
        {
        }

        internal override void WriteToXml(XmlWriter writer, SerializationContext serializationContext)
        {
            writer.WriteStartElement("ObjectIdentityQuery");
            writer.WriteAttributeString("Id", base.Id.ToString(CultureInfo.InvariantCulture));
            writer.WriteAttributeString("ObjectPathId", base.Path.Id.ToString(CultureInfo.InvariantCulture));
            serializationContext.AddObjectPath(base.Path);
            writer.WriteEndElement();
        }
    }
}
