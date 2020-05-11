using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Microsoft.Graph
{
    public partial class Subscription
    {
        /// <summary>
        /// Adds the encryption certificate information for change notifications with resource data to the subscription creation information.
        /// </summary>
        /// <param name="certificate">Certificate to use for encryption</param>
        public void AddEncryptionCertificate(X509Certificate2 certificate)
        {
            EncryptionCertificate = Convert.ToBase64String(certificate.Export(X509ContentType.SerializedCert));
            IncludeResourceData = true;
        }
    }
}
