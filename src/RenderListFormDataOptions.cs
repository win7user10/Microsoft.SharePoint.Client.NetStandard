using System;

namespace Microsoft.SharePoint.Client.NetStandard
{
    [Flags]
    public enum RenderListFormDataOptions
    {
        None = 0,
        ExcludeListSchema = 1,
        IncludeAttachments = 2,
        IncludeListViewData = 4
    }
}
