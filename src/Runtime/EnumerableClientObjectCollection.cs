using System.Collections;
using System.Collections.Generic;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    internal class EnumerableClientObjectCollection<T> : IEnumerable<T>, IEnumerable
    {
        private ClientObjectCollection<T> m_collection;

        public EnumerableClientObjectCollection(ClientObjectCollection<T> collection)
        {
            this.m_collection = collection;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.m_collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
