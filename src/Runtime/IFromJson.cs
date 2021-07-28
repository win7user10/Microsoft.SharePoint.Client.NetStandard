namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public interface IFromJson
    {
        void FromJson(JsonReader reader);

        bool CustomFromJson(JsonReader reader);
    }
}
