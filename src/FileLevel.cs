namespace Microsoft.SharePoint.Client.NetStandard
{
    public enum FileLevel : byte
    {
        Published = 1,
        Draft,
        Checkout = 255
    }
}
