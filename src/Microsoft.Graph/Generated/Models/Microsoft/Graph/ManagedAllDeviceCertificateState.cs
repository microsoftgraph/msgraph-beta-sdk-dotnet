using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ManagedAllDeviceCertificateState : Entity, IParsable {
        /// <summary>Certificate expiry date</summary>
        public DateTimeOffset? CertificateExpirationDateTime { get; set; }
        /// <summary>Enhanced Key Usage</summary>
        public string CertificateExtendedKeyUsages { get; set; }
        /// <summary>Issuance date</summary>
        public DateTimeOffset? CertificateIssuanceDateTime { get; set; }
        /// <summary>Issuer</summary>
        public string CertificateIssuerName { get; set; }
        /// <summary>Key Usage</summary>
        public int? CertificateKeyUsages { get; set; }
        /// <summary>Revoke status. Possible values are: none, pending, issued, failed, revoked.</summary>
        public CertificateRevocationStatus? CertificateRevokeStatus { get; set; }
        /// <summary>The time the revoke status was last changed</summary>
        public DateTimeOffset? CertificateRevokeStatusLastChangeDateTime { get; set; }
        /// <summary>Serial number</summary>
        public string CertificateSerialNumber { get; set; }
        /// <summary>Certificate subject name</summary>
        public string CertificateSubjectName { get; set; }
        /// <summary>Thumbprint</summary>
        public string CertificateThumbprint { get; set; }
        /// <summary>Device display name</summary>
        public string ManagedDeviceDisplayName { get; set; }
        /// <summary>User principal name</summary>
        public string UserPrincipalName { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"certificateExpirationDateTime", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateExtendedKeyUsages", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateExtendedKeyUsages = n.GetStringValue(); } },
                {"certificateIssuanceDateTime", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateIssuanceDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateIssuerName", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateIssuerName = n.GetStringValue(); } },
                {"certificateKeyUsages", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateKeyUsages = n.GetIntValue(); } },
                {"certificateRevokeStatus", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateRevokeStatus = n.GetEnumValue<CertificateRevocationStatus>(); } },
                {"certificateRevokeStatusLastChangeDateTime", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateRevokeStatusLastChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateSerialNumber", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateSerialNumber = n.GetStringValue(); } },
                {"certificateSubjectName", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateSubjectName = n.GetStringValue(); } },
                {"certificateThumbprint", (o,n) => { (o as ManagedAllDeviceCertificateState).CertificateThumbprint = n.GetStringValue(); } },
                {"managedDeviceDisplayName", (o,n) => { (o as ManagedAllDeviceCertificateState).ManagedDeviceDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as ManagedAllDeviceCertificateState).UserPrincipalName = n.GetStringValue(); } },
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
