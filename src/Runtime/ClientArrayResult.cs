namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class ClientArrayResult<T> : IFromJson
    {
        private T[] m_value;

        public T[] Value
        {
            get
            {
                return this.m_value;
            }
        }

        void IFromJson.FromJson(JsonReader reader)
        {
            this.m_value = reader.ReadArray<T>();
        }

        bool IFromJson.CustomFromJson(JsonReader reader)
        {
            return false;
        }
    }
}
