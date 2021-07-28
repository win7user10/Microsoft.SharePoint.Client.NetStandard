using System;

namespace Microsoft.SharePoint.Client.NetStandard
{
    public sealed class FormDigestInfo
    {
        public string DigestValue
        {
            get;
            internal set;
        }

        public DateTime Expiration
        {
            get;
            internal set;
        }

        internal Version RequestSchemaVersion
        {
            get;
            set;
        }

        internal FormDigestInfo()
        {
        }
    }
}
