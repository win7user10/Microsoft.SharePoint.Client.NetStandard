using System;
using System.IO;

namespace Microsoft.SharePoint.Client.NetStandard
{
    public sealed class FileInformation : IDisposable
    {
        private Stream m_stream;

        private string m_etag;

        public Stream Stream
        {
            get
            {
                return this.m_stream;
            }
        }

        public string ETag
        {
            get
            {
                return this.m_etag;
            }
        }

        internal FileInformation(Stream stream, string etag)
        {
            this.m_stream = stream;
            this.m_etag = etag;
        }

        public void Dispose()
        {
            if (this.m_stream != null)
            {
                this.m_stream.Dispose();
                this.m_stream = null;
            }
        }
    }
}
