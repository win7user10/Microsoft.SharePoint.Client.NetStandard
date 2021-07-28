using System.ComponentModel;
using System.Xml;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public abstract class ClientValueObject : IFromJson
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract string TypeId
        {
            get;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual void FromJson(JsonReader reader)
        {
            if (reader.PeekTokenType() == JsonTokenType.Null)
            {
                return;
            }
            reader.ReadObjectStart();
            while (reader.PeekTokenType() != JsonTokenType.ObjectEnd)
            {
                string peekedName = reader.PeekName();
                if (!this.InitOnePropertyFromJson(peekedName, reader))
                {
                    reader.ReadName();
                    reader.ReadObject();
                }
            }
            reader.ReadObjectEnd();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual bool InitOnePropertyFromJson(string peekedName, JsonReader reader)
        {
            return false;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual bool CustomFromJson(JsonReader reader)
        {
            return false;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual void WriteToXml(XmlWriter writer, SerializationContext serializationContext)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual bool CustomWriteToXml(XmlWriter writer, SerializationContext serializationContext)
        {
            return false;
        }
    }
}