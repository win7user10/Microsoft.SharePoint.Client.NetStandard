using System;
using System.ComponentModel;
using System.Xml;
using Microsoft.SharePoint.Client.NetStandard.Runtime;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [ScriptType("SP.FieldLinkCreationInformation", ValueObject = true, ServerTypeId = "{63fb2c92-8f65-4bbb-a658-b6cd294403f4}")]
    public class FieldLinkCreationInformation : ClientValueObject
    {
        private Field m_field;

        [Remote]
        public Field Field
        {
            get
            {
                return this.m_field;
            }
            set
            {
                this.m_field = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string TypeId
        {
            get
            {
                return "{63fb2c92-8f65-4bbb-a658-b6cd294403f4}";
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void WriteToXml(XmlWriter writer, SerializationContext serializationContext)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (serializationContext == null)
            {
                throw new ArgumentNullException("serializationContext");
            }
            writer.WriteStartElement("Property");
            writer.WriteAttributeString("Name", "Field");
            DataConvert.WriteValueToXmlElement(writer, this.Field, serializationContext);
            writer.WriteEndElement();
            base.WriteToXml(writer, serializationContext);
        }
    }
}
