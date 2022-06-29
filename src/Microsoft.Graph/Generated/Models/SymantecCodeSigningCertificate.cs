using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class SymantecCodeSigningCertificate : Entity, IParsable {
        /// <summary>The Windows Symantec Code-Signing Certificate in the raw data format.</summary>
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>(nameof(Content)); }
            set { BackingStore?.Set(nameof(Content), value); }
        }
        /// <summary>The Cert Expiration Date.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ExpirationDateTime), value); }
        }
        /// <summary>The Issuer value for the cert.</summary>
        public string Issuer {
            get { return BackingStore?.Get<string>(nameof(Issuer)); }
            set { BackingStore?.Set(nameof(Issuer), value); }
        }
        /// <summary>The Issuer Name for the cert.</summary>
        public string IssuerName {
            get { return BackingStore?.Get<string>(nameof(IssuerName)); }
            set { BackingStore?.Set(nameof(IssuerName), value); }
        }
        /// <summary>The Password required for .pfx file.</summary>
        public string Password {
            get { return BackingStore?.Get<string>(nameof(Password)); }
            set { BackingStore?.Set(nameof(Password), value); }
        }
        /// <summary>The Cert Status Provisioned or not Provisioned. Possible values are: notProvisioned, provisioned.</summary>
        public CertificateStatus? Status {
            get { return BackingStore?.Get<CertificateStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The Subject value for the cert.</summary>
        public string Subject {
            get { return BackingStore?.Get<string>(nameof(Subject)); }
            set { BackingStore?.Set(nameof(Subject), value); }
        }
        /// <summary>The Subject Name for the cert.</summary>
        public string SubjectName {
            get { return BackingStore?.Get<string>(nameof(SubjectName)); }
            set { BackingStore?.Set(nameof(SubjectName), value); }
        }
        /// <summary>The Type of the CodeSigning Cert as Symantec Cert.</summary>
        public DateTimeOffset? UploadDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(UploadDateTime)); }
            set { BackingStore?.Set(nameof(UploadDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SymantecCodeSigningCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SymantecCodeSigningCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"issuer", n => { Issuer = n.GetStringValue(); } },
                {"issuerName", n => { IssuerName = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<CertificateStatus>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"subjectName", n => { SubjectName = n.GetStringValue(); } },
                {"uploadDateTime", n => { UploadDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("password", Password);
            writer.WriteEnumValue<CertificateStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteDateTimeOffsetValue("uploadDateTime", UploadDateTime);
        }
    }
}
