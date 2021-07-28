using System.Collections.Generic;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public class ClientListResultHandler<T> : IFromJson
    {
        private IList<T> m_list;

        public ClientListResultHandler(IList<T> list)
        {
            this.m_list = list;
        }

        void IFromJson.FromJson(JsonReader reader)
        {
            T[] array = reader.ReadArray<T>();
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    this.m_list.Add(array[i]);
                }
            }
        }

        bool IFromJson.CustomFromJson(JsonReader reader)
        {
            return false;
        }
    }
}
