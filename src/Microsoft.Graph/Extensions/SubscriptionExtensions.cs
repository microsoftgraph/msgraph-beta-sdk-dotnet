using System;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.Graph.Beta.Models
{
    public static class SubscriptionExtensions
    {
        /// <summary>
        /// Adds the public encryption certificate information for change notifications with resource data to the subscription creation information.
        /// </summary>
        /// <param name="subscription">The subscription instance of type <see cref="Subscription"/></param>
        /// <param name="certificate">Certificate to use for encryption</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="certificate"/> is null</exception>
        public static void AddPublicEncryptionCertificate(this Subscription subscription, X509Certificate2 certificate)
        {
            if (certificate == null)
                throw new ArgumentNullException(nameof(certificate));

            var tempSubscription = new EncryptableSubscription();
            tempSubscription.AddPublicEncryptionCertificate(certificate);
            subscription.EncryptionCertificate = tempSubscription.EncryptionCertificate;
        }
    }

    internal class EncryptableSubscription : IEncryptableSubscription
    {
        /// <summary>
        /// The encryption certificate
        /// </summary>
        public string EncryptionCertificate
        {
            get; set;
        }
    }
}
