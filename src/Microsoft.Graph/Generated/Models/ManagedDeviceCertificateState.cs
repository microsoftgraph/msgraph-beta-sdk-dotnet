using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class ManagedDeviceCertificateState : Entity, IParsable {
        /// <summary>Extended key usage</summary>
        public string CertificateEnhancedKeyUsage {
            get { return BackingStore?.Get<string>("certificateEnhancedKeyUsage"); }
            set { BackingStore?.Set("certificateEnhancedKeyUsage", value); }
        }
        /// <summary>Error code</summary>
        public int? CertificateErrorCode {
            get { return BackingStore?.Get<int?>("certificateErrorCode"); }
            set { BackingStore?.Set("certificateErrorCode", value); }
        }
        /// <summary>Certificate expiry date</summary>
        public DateTimeOffset? CertificateExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("certificateExpirationDateTime"); }
            set { BackingStore?.Set("certificateExpirationDateTime", value); }
        }
        /// <summary>Issuance date</summary>
        public DateTimeOffset? CertificateIssuanceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("certificateIssuanceDateTime"); }
            set { BackingStore?.Set("certificateIssuanceDateTime", value); }
        }
        /// <summary>Certificate Issuance State Options.</summary>
        public CertificateIssuanceStates? CertificateIssuanceState {
            get { return BackingStore?.Get<CertificateIssuanceStates?>("certificateIssuanceState"); }
            set { BackingStore?.Set("certificateIssuanceState", value); }
        }
        /// <summary>Issuer</summary>
        public string CertificateIssuer {
            get { return BackingStore?.Get<string>("certificateIssuer"); }
            set { BackingStore?.Set("certificateIssuer", value); }
        }
        /// <summary>Key length</summary>
        public int? CertificateKeyLength {
            get { return BackingStore?.Get<int?>("certificateKeyLength"); }
            set { BackingStore?.Set("certificateKeyLength", value); }
        }
        /// <summary>Key Storage Provider (KSP) Import Options.</summary>
        public KeyStorageProviderOption? CertificateKeyStorageProvider {
            get { return BackingStore?.Get<KeyStorageProviderOption?>("certificateKeyStorageProvider"); }
            set { BackingStore?.Set("certificateKeyStorageProvider", value); }
        }
        /// <summary>Key Usage Options.</summary>
        public KeyUsages? CertificateKeyUsage {
            get { return BackingStore?.Get<KeyUsages?>("certificateKeyUsage"); }
            set { BackingStore?.Set("certificateKeyUsage", value); }
        }
        /// <summary>Last certificate issuance state change</summary>
        public DateTimeOffset? CertificateLastIssuanceStateChangedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("certificateLastIssuanceStateChangedDateTime"); }
            set { BackingStore?.Set("certificateLastIssuanceStateChangedDateTime", value); }
        }
        /// <summary>Certificate profile display name</summary>
        public string CertificateProfileDisplayName {
            get { return BackingStore?.Get<string>("certificateProfileDisplayName"); }
            set { BackingStore?.Set("certificateProfileDisplayName", value); }
        }
        /// <summary>Certificate Revocation Status.</summary>
        public CertificateRevocationStatus? CertificateRevokeStatus {
            get { return BackingStore?.Get<CertificateRevocationStatus?>("certificateRevokeStatus"); }
            set { BackingStore?.Set("certificateRevokeStatus", value); }
        }
        /// <summary>Serial number</summary>
        public string CertificateSerialNumber {
            get { return BackingStore?.Get<string>("certificateSerialNumber"); }
            set { BackingStore?.Set("certificateSerialNumber", value); }
        }
        /// <summary>Subject Alternative Name Options.</summary>
        public SubjectAlternativeNameType? CertificateSubjectAlternativeNameFormat {
            get { return BackingStore?.Get<SubjectAlternativeNameType?>("certificateSubjectAlternativeNameFormat"); }
            set { BackingStore?.Set("certificateSubjectAlternativeNameFormat", value); }
        }
        /// <summary>Subject alternative name format string for custom formats</summary>
        public string CertificateSubjectAlternativeNameFormatString {
            get { return BackingStore?.Get<string>("certificateSubjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("certificateSubjectAlternativeNameFormatString", value); }
        }
        /// <summary>Subject Name Format Options.</summary>
        public SubjectNameFormat? CertificateSubjectNameFormat {
            get { return BackingStore?.Get<SubjectNameFormat?>("certificateSubjectNameFormat"); }
            set { BackingStore?.Set("certificateSubjectNameFormat", value); }
        }
        /// <summary>Subject name format string for custom subject name formats</summary>
        public string CertificateSubjectNameFormatString {
            get { return BackingStore?.Get<string>("certificateSubjectNameFormatString"); }
            set { BackingStore?.Set("certificateSubjectNameFormatString", value); }
        }
        /// <summary>Thumbprint</summary>
        public string CertificateThumbprint {
            get { return BackingStore?.Get<string>("certificateThumbprint"); }
            set { BackingStore?.Set("certificateThumbprint", value); }
        }
        /// <summary>Validity period</summary>
        public int? CertificateValidityPeriod {
            get { return BackingStore?.Get<int?>("certificateValidityPeriod"); }
            set { BackingStore?.Set("certificateValidityPeriod", value); }
        }
        /// <summary>Certificate Validity Period Options.</summary>
        public CertificateValidityPeriodScale? CertificateValidityPeriodUnits {
            get { return BackingStore?.Get<CertificateValidityPeriodScale?>("certificateValidityPeriodUnits"); }
            set { BackingStore?.Set("certificateValidityPeriodUnits", value); }
        }
        /// <summary>Device display name</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
        /// <summary>Supported platform types.</summary>
        public DevicePlatformType? DevicePlatform {
            get { return BackingStore?.Get<DevicePlatformType?>("devicePlatform"); }
            set { BackingStore?.Set("devicePlatform", value); }
        }
        /// <summary>Last certificate issuance state change</summary>
        public DateTimeOffset? LastCertificateStateChangeDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCertificateStateChangeDateTime"); }
            set { BackingStore?.Set("lastCertificateStateChangeDateTime", value); }
        }
        /// <summary>User display name</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
        /// <summary>
        /// Instantiates a new managedDeviceCertificateState and sets the default values.
        /// </summary>
        public ManagedDeviceCertificateState() : base() {
            OdataType = "#microsoft.graph.managedDeviceCertificateState";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDeviceCertificateState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceCertificateState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificateEnhancedKeyUsage", n => { CertificateEnhancedKeyUsage = n.GetStringValue(); } },
                {"certificateErrorCode", n => { CertificateErrorCode = n.GetIntValue(); } },
                {"certificateExpirationDateTime", n => { CertificateExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateIssuanceDateTime", n => { CertificateIssuanceDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateIssuanceState", n => { CertificateIssuanceState = n.GetEnumValue<CertificateIssuanceStates>(); } },
                {"certificateIssuer", n => { CertificateIssuer = n.GetStringValue(); } },
                {"certificateKeyLength", n => { CertificateKeyLength = n.GetIntValue(); } },
                {"certificateKeyStorageProvider", n => { CertificateKeyStorageProvider = n.GetEnumValue<KeyStorageProviderOption>(); } },
                {"certificateKeyUsage", n => { CertificateKeyUsage = n.GetEnumValue<KeyUsages>(); } },
                {"certificateLastIssuanceStateChangedDateTime", n => { CertificateLastIssuanceStateChangedDateTime = n.GetDateTimeOffsetValue(); } },
                {"certificateProfileDisplayName", n => { CertificateProfileDisplayName = n.GetStringValue(); } },
                {"certificateRevokeStatus", n => { CertificateRevokeStatus = n.GetEnumValue<CertificateRevocationStatus>(); } },
                {"certificateSerialNumber", n => { CertificateSerialNumber = n.GetStringValue(); } },
                {"certificateSubjectAlternativeNameFormat", n => { CertificateSubjectAlternativeNameFormat = n.GetEnumValue<SubjectAlternativeNameType>(); } },
                {"certificateSubjectAlternativeNameFormatString", n => { CertificateSubjectAlternativeNameFormatString = n.GetStringValue(); } },
                {"certificateSubjectNameFormat", n => { CertificateSubjectNameFormat = n.GetEnumValue<SubjectNameFormat>(); } },
                {"certificateSubjectNameFormatString", n => { CertificateSubjectNameFormatString = n.GetStringValue(); } },
                {"certificateThumbprint", n => { CertificateThumbprint = n.GetStringValue(); } },
                {"certificateValidityPeriod", n => { CertificateValidityPeriod = n.GetIntValue(); } },
                {"certificateValidityPeriodUnits", n => { CertificateValidityPeriodUnits = n.GetEnumValue<CertificateValidityPeriodScale>(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"devicePlatform", n => { DevicePlatform = n.GetEnumValue<DevicePlatformType>(); } },
                {"lastCertificateStateChangeDateTime", n => { LastCertificateStateChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("certificateEnhancedKeyUsage", CertificateEnhancedKeyUsage);
            writer.WriteIntValue("certificateErrorCode", CertificateErrorCode);
            writer.WriteDateTimeOffsetValue("certificateExpirationDateTime", CertificateExpirationDateTime);
            writer.WriteDateTimeOffsetValue("certificateIssuanceDateTime", CertificateIssuanceDateTime);
            writer.WriteEnumValue<CertificateIssuanceStates>("certificateIssuanceState", CertificateIssuanceState);
            writer.WriteStringValue("certificateIssuer", CertificateIssuer);
            writer.WriteIntValue("certificateKeyLength", CertificateKeyLength);
            writer.WriteEnumValue<KeyStorageProviderOption>("certificateKeyStorageProvider", CertificateKeyStorageProvider);
            writer.WriteEnumValue<KeyUsages>("certificateKeyUsage", CertificateKeyUsage);
            writer.WriteDateTimeOffsetValue("certificateLastIssuanceStateChangedDateTime", CertificateLastIssuanceStateChangedDateTime);
            writer.WriteStringValue("certificateProfileDisplayName", CertificateProfileDisplayName);
            writer.WriteEnumValue<CertificateRevocationStatus>("certificateRevokeStatus", CertificateRevokeStatus);
            writer.WriteStringValue("certificateSerialNumber", CertificateSerialNumber);
            writer.WriteEnumValue<SubjectAlternativeNameType>("certificateSubjectAlternativeNameFormat", CertificateSubjectAlternativeNameFormat);
            writer.WriteStringValue("certificateSubjectAlternativeNameFormatString", CertificateSubjectAlternativeNameFormatString);
            writer.WriteEnumValue<SubjectNameFormat>("certificateSubjectNameFormat", CertificateSubjectNameFormat);
            writer.WriteStringValue("certificateSubjectNameFormatString", CertificateSubjectNameFormatString);
            writer.WriteStringValue("certificateThumbprint", CertificateThumbprint);
            writer.WriteIntValue("certificateValidityPeriod", CertificateValidityPeriod);
            writer.WriteEnumValue<CertificateValidityPeriodScale>("certificateValidityPeriodUnits", CertificateValidityPeriodUnits);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteEnumValue<DevicePlatformType>("devicePlatform", DevicePlatform);
            writer.WriteDateTimeOffsetValue("lastCertificateStateChangeDateTime", LastCertificateStateChangeDateTime);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
        }
    }
}
