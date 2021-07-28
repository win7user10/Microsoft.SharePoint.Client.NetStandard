using System.Globalization;
using System.Xml;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class ObjectPathProperty : ObjectPath
    {
        private string m_propertyName;

        internal override string ObjectName
        {
            get
            {
                return Resources.GetString("ObjectNameProperty", new object[]
                {
                    this.m_propertyName
                });
            }
        }

        public ObjectPathProperty(ClientRuntimeContext context, ObjectPath parent, string propertyName) : base(context, parent, true)
        {
            this.m_propertyName = propertyName;
        }

        internal override void WriteToXml(XmlWriter writer, SerializationContext serializationContext)
        {
            writer.WriteStartElement("Property");
            writer.WriteAttributeString("Id", base.Id.ToString(CultureInfo.InvariantCulture));
            writer.WriteAttributeString("ParentId", base.Parent.Id.ToString(CultureInfo.InvariantCulture));
            serializationContext.AddObjectPath(base.Parent);
            writer.WriteAttributeString("Name", this.m_propertyName);
            writer.WriteEndElement();
        }
    }
}
