using System.ComponentModel;
using Microsoft.SharePoint.Client.NetStandard.Runtime;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [ScriptType("SP.ChangeCollection", ServerTypeId = "{2ba7a459-eeda-42d0-90e2-fad3487ad0d3}")]
    public sealed class ChangeCollection : ClientObjectCollection<Change>
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChangeCollection(ClientRuntimeContext context, ObjectPath objectPath) : base(context, objectPath)
        {
        }
    }
}
