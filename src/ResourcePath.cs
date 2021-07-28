using System;
using System.ComponentModel;
using System.Xml;
using Microsoft.SharePoint.Client.NetStandard.Runtime;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [ScriptType("SP.ResourcePath", ValueObject = true, ServerTypeId = "{a265a356-274b-4e6c-b0ef-bbc22bd0969a}")]
    public class ResourcePath : ClientValueObject
    {
        private string m_decodedUrl;

        [Remote]
        public string DecodedUrl
        {
            get
            {
                return this.m_decodedUrl;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string TypeId
        {
            get
            {
                return "{a265a356-274b-4e6c-b0ef-bbc22bd0969a}";
            }
        }

        public static ResourcePath FromDecodedUrl(string decodedUrl)
        {
            if (decodedUrl == null)
            {
                return null;
            }
            return new ResourcePath
            {
                m_decodedUrl = decodedUrl
            };
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
            writer.WriteAttributeString("Name", "DecodedUrl");
            DataConvert.WriteValueToXmlElement(writer, this.DecodedUrl, serializationContext);
            writer.WriteEndElement();
            base.WriteToXml(writer, serializationContext);
        }

        protected override bool InitOnePropertyFromJson(string peekedName, JsonReader reader)
        {
            bool flag = base.InitOnePropertyFromJson(peekedName, reader);
            if (flag)
            {
                return flag;
            }
            if (peekedName != null && peekedName == "DecodedUrl")
            {
                flag = true;
                reader.ReadName();
                this.m_decodedUrl = reader.ReadString();
            }
            return flag;
        }
    }
}
