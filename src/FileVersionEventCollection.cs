using System.ComponentModel;
using Microsoft.SharePoint.Client.NetStandard.Runtime;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [ScriptType("SP.FileVersionEventCollection", ServerTypeId = "{098c4937-812c-449a-9d93-f4bb34e22323}")]
    public class FileVersionEventCollection : ClientObjectCollection<FileVersionEvent>
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public FileVersionEventCollection(ClientRuntimeContext context, ObjectPath objectPath) : base(context, objectPath)
        {
        }
    }
}
