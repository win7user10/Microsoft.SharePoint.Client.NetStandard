namespace Microsoft.SharePoint.Client.NetStandard.Mime
{
    internal class MimeHeader
    {
        private string name;

        private string value;

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Value
        {
            get
            {
                return this.value;
            }
        }

        public MimeHeader(string name, string value)
        {
            if (name == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("name");
            }
            this.name = name;
            this.value = value;
        }
    }
}
