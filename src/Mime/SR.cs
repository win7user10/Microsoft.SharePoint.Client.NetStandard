using Microsoft.SharePoint.Client.NetStandard.Runtime;

namespace Microsoft.SharePoint.Client.NetStandard.Mime
{

    internal static class SR
    {
        public const string MimeWriterInvalidStateForStartPart = "MimeWriterInvalidStateForStartPart";

        public const string MimeWriterInvalidStateForClose = "MimeWriterInvalidStateForClose";

        public const string MimeWriterInvalidStateForStartPreface = "MimeWriterInvalidStateForStartPreface";

        public const string MimeWriterInvalidStateForHeader = "MimeWriterInvalidStateForHeader";

        public const string MimeWriterInvalidStateForContent = "MimeWriterInvalidStateForContent";

        public const string MimeVersionHeaderInvalid = "MimeVersionHeaderInvalid";

        public const string MimeContentLengthHeaderInvalid = "MimeContentLengthHeaderInvalid";

        public const string MimeHeaderInvalidCharacter = "MimeHeaderInvalidCharacter";

        public const string MimeReaderMalformedHeader = "MimeReaderMalformedHeader";

        public const string MimeContentTypeHeaderInvalid = "MimeContentTypeHeaderInvalid";

        public const string MimeReaderHeaderAlreadyExists = "MimeReaderHeaderAlreadyExists";

        public const string MimeMessageGetContentStreamCalledAlready = "MimeMessageGetContentStreamCalledAlready";

        public const string MimeReaderResetCalledBeforeEOF = "MimeReaderResetCalledBeforeEOF";

        public const string WriteBufferOverflow = "WriteBufferOverflow";

        public const string MimeReaderTruncated = "MimeReaderTruncated";

        public const string MtomExceededMaxSizeInBytes = "MtomExceededMaxSizeInBytes";

        public const string MtomBufferQuotaExceeded = "MtomBufferQuotaExceeded";

        public static string GetString(string resourceId, params object[] args)
        {
            return Resources.GetString(resourceId, args);
        }
    }
}
