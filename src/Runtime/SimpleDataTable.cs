using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public sealed class SimpleDataTable
    {
        private Collection<Dictionary<string, object>> m_rows;

        public Collection<Dictionary<string, object>> Rows
        {
            get
            {
                if (this.m_rows == null)
                {
                    this.m_rows = new Collection<Dictionary<string, object>>();
                }
                return this.m_rows;
            }
        }
    }
}
