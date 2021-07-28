using System;
using System.ComponentModel;
using System.Xml;
using Microsoft.SharePoint.Client.NetStandard.Runtime;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [ScriptType("SP.SharedWithUserCollection", ValueObject = true, ServerTypeId = "{c60fa59c-1de9-4b4f-a6ed-2b4b625ff300}")]
    public sealed class SharedWithUserCollection : ClientValueObjectCollection<SharedWithUser>
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string TypeId
        {
            get
            {
                return "{c60fa59c-1de9-4b4f-a6ed-2b4b625ff300}";
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
            base.WriteToXml(writer, serializationContext);
        }
    }
}
