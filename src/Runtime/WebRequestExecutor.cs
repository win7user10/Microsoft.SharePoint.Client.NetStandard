using System;
using System.IO;
using System.Net;

namespace Microsoft.SharePoint.Client.NetStandard.Runtime
{
    public abstract class WebRequestExecutor : IDisposable
    {
        public virtual HttpWebRequest WebRequest
        {
            get
            {
                return null;
            }
        }

        public abstract string RequestContentType
        {
            get;
            set;
        }

        public abstract WebHeaderCollection RequestHeaders
        {
            get;
        }

        public abstract string RequestMethod
        {
            get;
            set;
        }

        public abstract bool RequestKeepAlive
        {
            get;
            set;
        }

        public abstract HttpStatusCode StatusCode
        {
            get;
        }

        public abstract string ResponseContentType
        {
            get;
        }

        public abstract WebHeaderCollection ResponseHeaders
        {
            get;
        }

        public abstract Stream GetRequestStream();

        public abstract void Execute();

        public abstract Stream GetResponseStream();

        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
