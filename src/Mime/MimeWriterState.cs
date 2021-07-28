namespace Microsoft.SharePoint.Client.NetStandard.Mime
{
    internal enum MimeWriterState
    {
        Start,
        StartPreface,
        StartPart,
        Header,
        Content,
        Closed
    }
}
