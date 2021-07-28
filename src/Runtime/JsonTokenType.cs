namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public enum JsonTokenType
    {
        ObjectStart,
        ObjectEnd,
        ArrayStart,
        ArrayEnd,
        String,
        Long,
        ULong,
        Double,
        Boolean,
        DateTime,
        Guid,
        Null,
        Name,
        ByteArray,
        StreamLink
    }
}
