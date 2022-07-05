using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class ManagedAllDeviceCertificateState : Entity, IParsable {
        /// <summary>Certificate expiry date</summary>
        public DateTimeOffset? CertificateExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CertificateExpirationDateTime)); }
            set { BackingStore?.Set(nameof(CertificateExpirationDateTime), value); }
        }
        /// <summary>Enhanced Key Usage</summary>
        public string CertificateExtendedKeyUsages {
            get { return BackingStore?.Get<string>(nameof(CertificateExtendedKeyUsages)); }
            set { BackingStore?.Set(nameof(CertificateExtendedKeyUsages), value); }
        }
        /// <summary>Issuance date</summary>
        public DateTimeOffset? CertificateIssuanceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CertificateIssuanceDateTime)); }
            set { BackingStore?.Set(nameof(CertificateIssuanceDateTime), value); }
        }
        /// <summary>Issuer</summary>
        public string CertificateIssuerName {
            get { return BackingStore?.Get<string>(nameof(CertificateIssuerName)); }
            set { BackingStore?.Set(nameof(CertificateIssuerName), value); }
        }
        /// <summary>Key Usage</summary>
        public int? CertificateKeyUsages {
            get { return BackingStore?.Get<int?>(nameof(CertificateKeyUsages)); }
            set { BackingStore?.Set(nameof(CertificateKeyUsages), value); }
        }
        /// <summary>Revoke status. Possible values are: none, pending, issued, failed, revoked.</summary>
        public CertificateRevocationStatus? CertificateRevokeStatus {
            get { return BackingStore?.Get<CertificateRevocationStatus?>(nameof(CertificateRevokeStatus)); }
            set { BackingStore?.Set(nameof(CertificateRevokeStatus), value); }
        }
        /// <summary>The time the revoke status was last changed</summary>
        public DateTimeOffset? CertificateRevokeStatusLastChangeDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CertificateRevokeStatusLastChangeDateTime)); }
            set { BackingStore?.Set(nameof(CertificateRevokeStatusLastChangeDateTime), value); }
        }
        /// <summary>Serial number</summary>
        public string CertificateSerialNumber {
            get { return BackingStore?.Get<string>(nameof(CertificateSerialNumber)); }
            set { BackingStore?.Set(nameof(CertificateSerialNumber), value); }
        }
        /// <summary>Certificate subject name</summary>
        public string CertificateSubjectName {
            get { return BackingStore?.Get<string>(nameof(CertificateSubjectName)); }
            set { BackingStore?.Set(nameof(CertificateSubjectName), value); }
        }
        /// <summary>Thumbprint</summary>
        public string CertificateThumbprint {
            get { return BackingStore?.Get<string>(nameof(CertificateThumbprint)); }
            set { BackingStore?.Set(nameof(CertificateThumbprint), value); }
        }
        /// <summary>Device display name</summary>
        public string ManagedDeviceDisplayName {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceDisplayName)); }
            set { BackingStore?.Set(nameof(ManagedDeviceDisplayName), value); }
        }
        /// <summary>User principal name</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedAllDeviceCertificateState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAllDeviceCertificateState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateExpirationDateTime", n => { CertificateExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateExtendedKeyUsages", n => { CertificateExtendedKeyUsages = n.GetStringValue(); } },
                {"certificateIssuanceDateTime", n => { CertificateIssuanceDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateIssuerName", n => { CertificateIssuerName = n.GetStringValue(); } },
                {"certificateKeyUsages", n => { CertificateKeyUsages = n.GetIntValue(); } },
                {"certificateRevokeStatus", n => { CertificateRevokeStatus = n.GetEnumValue<CertificateRevocationStatus>(); } },
                {"certificateRevokeStatusLastChangeDateTime", n => { CertificateRevokeStatusLastChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateSerialNumber", n => { CertificateSerialNumber = n.GetStringValue(); } },
                {"certificateSubjectName", n => { CertificateSubjectName = n.GetStringValue(); } },
                {"certificateThumbprint", n => { CertificateThumbprint = n.GetStringValue(); } },
                {"managedDeviceDisplayName", n => { ManagedDeviceDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("certificateExpirationDateTime", CertificateExpirationDateTime);
            writer.WriteStringValue("certificateExtendedKeyUsages", CertificateExtendedKeyUsages);
            writer.WriteDateTimeOffsetValue("certificateIssuanceDateTime", CertificateIssuanceDateTime);
            writer.WriteStringValue("certificateIssuerName", CertificateIssuerName);
            writer.WriteIntValue("certificateKeyUsages", CertificateKeyUsages);
            writer.WriteEnumValue<CertificateRevocationStatus>("certificateRevokeStatus", CertificateRevokeStatus);
            writer.WriteDateTimeOffsetValue("certificateRevokeStatusLastChangeDateTime", CertificateRevokeStatusLastChangeDateTime);
            writer.WriteStringValue("certificateSerialNumber", CertificateSerialNumber);
            writer.WriteStringValue("certificateSubjectName", CertificateSubjectName);
            writer.WriteStringValue("certificateThumbprint", CertificateThumbprint);
            writer.WriteStringValue("managedDeviceDisplayName", ManagedDeviceDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
