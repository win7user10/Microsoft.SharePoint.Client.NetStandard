using System;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    [Flags]
    internal enum JsonReaderOptions
    {
        None = 0,
        DoNotUseEscapedToken = 1,
        IgnoreStringValue = 2
    }
}
