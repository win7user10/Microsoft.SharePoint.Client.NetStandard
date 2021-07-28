namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class ClientObjectCollectionPrototype<ItemType> : ClientObjectPrototype
    {
        private ClientObjectPrototype<ItemType> m_itemQuery;

        internal ClientObjectCollectionPrototype(ClientQueryInternal query, bool childItem) : base(query, childItem)
        {
        }

        public ClientObjectPrototype<ItemType> RetrieveItems()
        {
            if (this.m_itemQuery == null)
            {
                this.m_itemQuery = new ClientObjectPrototype<ItemType>(base.Query, true);
            }
            return this.m_itemQuery;
        }
    }
}
