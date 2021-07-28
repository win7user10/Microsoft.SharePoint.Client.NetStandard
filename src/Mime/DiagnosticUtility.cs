using System;

namespace Microsoft.SharePoint.Client.NetStandard.Mime
{
    internal static class DiagnosticUtility
    {
        public static class ExceptionUtility
        {
            public static Exception ThrowHelperError(Exception ex)
            {
                return ex;
            }

            public static Exception ThrowHelperArgumentNull(string argumentName)
            {
                return new ArgumentNullException(argumentName);
            }
        }
    }
}
