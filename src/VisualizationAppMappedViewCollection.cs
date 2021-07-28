using System.ComponentModel;
using Microsoft.SharePoint.Client.NetStandard.Runtime;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [ScriptType("SP.VisualizationAppMappedViewCollection", ServerTypeId = "{97c60f7b-3061-47c1-a65d-444d8ead845d}")]
    public sealed class VisualizationAppMappedViewCollection : ClientObjectCollection<View>
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VisualizationAppMappedViewCollection(ClientRuntimeContext context, ObjectPath objectPath) : base(context, objectPath)
        {
        }
    }
}