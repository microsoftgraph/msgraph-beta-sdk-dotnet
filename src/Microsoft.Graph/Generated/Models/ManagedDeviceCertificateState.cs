using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ManagedDeviceCertificateState : Entity, IParsable {
        /// <summary>Extended key usage</summary>
        public string CertificateEnhancedKeyUsage {
            get { return BackingStore?.Get<string>(nameof(CertificateEnhancedKeyUsage)); }
            set { BackingStore?.Set(nameof(CertificateEnhancedKeyUsage), value); }
        }
        /// <summary>Error code</summary>
        public int? CertificateErrorCode {
            get { return BackingStore?.Get<int?>(nameof(CertificateErrorCode)); }
            set { BackingStore?.Set(nameof(CertificateErrorCode), value); }
        }
        /// <summary>Certificate expiry date</summary>
        public DateTimeOffset? CertificateExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CertificateExpirationDateTime)); }
            set { BackingStore?.Set(nameof(CertificateExpirationDateTime), value); }
        }
        /// <summary>Issuance date</summary>
        public DateTimeOffset? CertificateIssuanceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CertificateIssuanceDateTime)); }
            set { BackingStore?.Set(nameof(CertificateIssuanceDateTime), value); }
        }
        /// <summary>Issuance State. Possible values are: unknown, challengeIssued, challengeIssueFailed, requestCreationFailed, requestSubmitFailed, challengeValidationSucceeded, challengeValidationFailed, issueFailed, issuePending, issued, responseProcessingFailed, responsePending, enrollmentSucceeded, enrollmentNotNeeded, revoked, removedFromCollection, renewVerified, installFailed, installed, deleteFailed, deleted, renewalRequested, requested.</summary>
        public CertificateIssuanceStates? CertificateIssuanceState {
            get { return BackingStore?.Get<CertificateIssuanceStates?>(nameof(CertificateIssuanceState)); }
            set { BackingStore?.Set(nameof(CertificateIssuanceState), value); }
        }
        /// <summary>Issuer</summary>
        public string CertificateIssuer {
            get { return BackingStore?.Get<string>(nameof(CertificateIssuer)); }
            set { BackingStore?.Set(nameof(CertificateIssuer), value); }
        }
        /// <summary>Key length</summary>
        public int? CertificateKeyLength {
            get { return BackingStore?.Get<int?>(nameof(CertificateKeyLength)); }
            set { BackingStore?.Set(nameof(CertificateKeyLength), value); }
        }
        /// <summary>Key Storage Provider. Possible values are: useTpmKspOtherwiseUseSoftwareKsp, useTpmKspOtherwiseFail, usePassportForWorkKspOtherwiseFail, useSoftwareKsp.</summary>
        public KeyStorageProviderOption? CertificateKeyStorageProvider {
            get { return BackingStore?.Get<KeyStorageProviderOption?>(nameof(CertificateKeyStorageProvider)); }
            set { BackingStore?.Set(nameof(CertificateKeyStorageProvider), value); }
        }
        /// <summary>Key usage. Possible values are: keyEncipherment, digitalSignature.</summary>
        public KeyUsages? CertificateKeyUsage {
            get { return BackingStore?.Get<KeyUsages?>(nameof(CertificateKeyUsage)); }
            set { BackingStore?.Set(nameof(CertificateKeyUsage), value); }
        }
        /// <summary>Last certificate issuance state change</summary>
        public DateTimeOffset? CertificateLastIssuanceStateChangedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CertificateLastIssuanceStateChangedDateTime)); }
            set { BackingStore?.Set(nameof(CertificateLastIssuanceStateChangedDateTime), value); }
        }
        /// <summary>Certificate profile display name</summary>
        public string CertificateProfileDisplayName {
            get { return BackingStore?.Get<string>(nameof(CertificateProfileDisplayName)); }
            set { BackingStore?.Set(nameof(CertificateProfileDisplayName), value); }
        }
        /// <summary>Revoke status. Possible values are: none, pending, issued, failed, revoked.</summary>
        public CertificateRevocationStatus? CertificateRevokeStatus {
            get { return BackingStore?.Get<CertificateRevocationStatus?>(nameof(CertificateRevokeStatus)); }
            set { BackingStore?.Set(nameof(CertificateRevokeStatus), value); }
        }
        /// <summary>Serial number</summary>
        public string CertificateSerialNumber {
            get { return BackingStore?.Get<string>(nameof(CertificateSerialNumber)); }
            set { BackingStore?.Set(nameof(CertificateSerialNumber), value); }
        }
        /// <summary>Subject alternative name format. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.</summary>
        public SubjectAlternativeNameType? CertificateSubjectAlternativeNameFormat {
            get { return BackingStore?.Get<SubjectAlternativeNameType?>(nameof(CertificateSubjectAlternativeNameFormat)); }
            set { BackingStore?.Set(nameof(CertificateSubjectAlternativeNameFormat), value); }
        }
        /// <summary>Subject alternative name format string for custom formats</summary>
        public string CertificateSubjectAlternativeNameFormatString {
            get { return BackingStore?.Get<string>(nameof(CertificateSubjectAlternativeNameFormatString)); }
            set { BackingStore?.Set(nameof(CertificateSubjectAlternativeNameFormatString), value); }
        }
        /// <summary>Subject name format. Possible values are: commonName, commonNameIncludingEmail, commonNameAsEmail, custom, commonNameAsIMEI, commonNameAsSerialNumber, commonNameAsAadDeviceId, commonNameAsIntuneDeviceId, commonNameAsDurableDeviceId.</summary>
        public SubjectNameFormat? CertificateSubjectNameFormat {
            get { return BackingStore?.Get<SubjectNameFormat?>(nameof(CertificateSubjectNameFormat)); }
            set { BackingStore?.Set(nameof(CertificateSubjectNameFormat), value); }
        }
        /// <summary>Subject name format string for custom subject name formats</summary>
        public string CertificateSubjectNameFormatString {
            get { return BackingStore?.Get<string>(nameof(CertificateSubjectNameFormatString)); }
            set { BackingStore?.Set(nameof(CertificateSubjectNameFormatString), value); }
        }
        /// <summary>Thumbprint</summary>
        public string CertificateThumbprint {
            get { return BackingStore?.Get<string>(nameof(CertificateThumbprint)); }
            set { BackingStore?.Set(nameof(CertificateThumbprint), value); }
        }
        /// <summary>Validity period</summary>
        public int? CertificateValidityPeriod {
            get { return BackingStore?.Get<int?>(nameof(CertificateValidityPeriod)); }
            set { BackingStore?.Set(nameof(CertificateValidityPeriod), value); }
        }
        /// <summary>Validity period units. Possible values are: days, months, years.</summary>
        public CertificateValidityPeriodScale? CertificateValidityPeriodUnits {
            get { return BackingStore?.Get<CertificateValidityPeriodScale?>(nameof(CertificateValidityPeriodUnits)); }
            set { BackingStore?.Set(nameof(CertificateValidityPeriodUnits), value); }
        }
        /// <summary>Device display name</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>(nameof(DeviceDisplayName)); }
            set { BackingStore?.Set(nameof(DeviceDisplayName), value); }
        }
        /// <summary>Device platform. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown, androidAOSP.</summary>
        public DevicePlatformType? DevicePlatform {
            get { return BackingStore?.Get<DevicePlatformType?>(nameof(DevicePlatform)); }
            set { BackingStore?.Set(nameof(DevicePlatform), value); }
        }
        /// <summary>Last certificate issuance state change</summary>
        public DateTimeOffset? LastCertificateStateChangeDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastCertificateStateChangeDateTime)); }
            set { BackingStore?.Set(nameof(LastCertificateStateChangeDateTime), value); }
        }
        /// <summary>User display name</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
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
