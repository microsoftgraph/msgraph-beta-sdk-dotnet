using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class VerifiedCustomDomainCertificatesMetadata : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpiryDate { get; set; }
        /// <summary>The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? IssueDate { get; set; }
        /// <summary>The issuer name of the custom domain certificate.</summary>
        public string IssuerName { get; set; }
        /// <summary>The subject name of the custom domain certificate.</summary>
        public string SubjectName { get; set; }
        /// <summary>The thumbprint associated with the custom domain certificate.</summary>
        public string Thumbprint { get; set; }
        /// <summary>
        /// Instantiates a new verifiedCustomDomainCertificatesMetadata and sets the default values.
        /// </summary>
        public VerifiedCustomDomainCertificatesMetadata() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VerifiedCustomDomainCertificatesMetadata CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifiedCustomDomainCertificatesMetadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expiryDate", (o,n) => { (o as VerifiedCustomDomainCertificatesMetadata).ExpiryDate = n.GetDateTimeOffsetValue(); } },
                {"issueDate", (o,n) => { (o as VerifiedCustomDomainCertificatesMetadata).IssueDate = n.GetDateTimeOffsetValue(); } },
                {"issuerName", (o,n) => { (o as VerifiedCustomDomainCertificatesMetadata).IssuerName = n.GetStringValue(); } },
                {"subjectName", (o,n) => { (o as VerifiedCustomDomainCertificatesMetadata).SubjectName = n.GetStringValue(); } },
                {"thumbprint", (o,n) => { (o as VerifiedCustomDomainCertificatesMetadata).Thumbprint = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expiryDate", ExpiryDate);
            writer.WriteDateTimeOffsetValue("issueDate", IssueDate);
            writer.WriteStringValue("issuerName", IssuerName);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteStringValue("thumbprint", Thumbprint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
