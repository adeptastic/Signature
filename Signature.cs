using System;

namespace Signature
{
    public class SignatureInformation
    {
        public DateTime SignatureDate { get; set; }
        public string DocumentID { get; set; }
        public string DocumentTitle { get; set; }
        public string AuthenticatedAccount { get; set; }
        public string FullName { get; set; }
        public string Initials { get; set; }
    }
}
