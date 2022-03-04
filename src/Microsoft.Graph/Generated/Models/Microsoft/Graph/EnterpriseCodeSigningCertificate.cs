using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class EnterpriseCodeSigningCertificate : Entity, IParsable {
        /// <summary>The Windows Enterprise Code-Signing Certificate in the raw data format.</summary>
        public byte[] Content { get; set; }
        /// <summary>The Cert Expiration Date.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The Issuer value for the cert.</summary>
        public string Issuer { get; set; }
        /// <summary>The Issuer Name for the cert.</summary>
        public string IssuerName { get; set; }
        /// <summary>The Certificate Status Provisioned or not Provisioned. Possible values are: notProvisioned, provisioned.</summary>
        public CertificateStatus? Status { get; set; }
        /// <summary>The Subject Value for the cert.</summary>
        public string Subject { get; set; }
        /// <summary>The Subject Name for the cert.</summary>
        public string SubjectName { get; set; }
        /// <summary>The date time of CodeSigning Cert when it is uploaded.</summary>
        public DateTimeOffset? UploadDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EnterpriseCodeSigningCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnterpriseCodeSigningCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as EnterpriseCodeSigningCertificate).Content = n.GetByteArrayValue(); } },
                {"expirationDateTime", (o,n) => { (o as EnterpriseCodeSigningCertificate).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"issuer", (o,n) => { (o as EnterpriseCodeSigningCertificate).Issuer = n.GetStringValue(); } },
                {"issuerName", (o,n) => { (o as EnterpriseCodeSigningCertificate).IssuerName = n.GetStringValue(); } },
                {"status", (o,n) => { (o as EnterpriseCodeSigningCertificate).Status = n.GetEnumValue<CertificateStatus>(); } },
                {"subject", (o,n) => { (o as EnterpriseCodeSigningCertificate).Subject = n.GetStringValue(); } },
                {"subjectName", (o,n) => { (o as EnterpriseCodeSigningCertificate).SubjectName = n.GetStringValue(); } },
                {"uploadDateTime", (o,n) => { (o as EnterpriseCodeSigningCertificate).UploadDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("issuerName", IssuerName);
            writer.WriteEnumValue<CertificateStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteDateTimeOffsetValue("uploadDateTime", UploadDateTime);
        }
    }
}
