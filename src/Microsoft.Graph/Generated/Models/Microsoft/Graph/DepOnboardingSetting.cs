using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DepOnboardingSetting : Entity, IParsable {
        /// <summary>The Apple ID used to obtain the current token.</summary>
        public string AppleIdentifier { get; set; }
        /// <summary>Consent granted for data sharing with Apple Dep Service</summary>
        public bool? DataSharingConsentGranted { get; set; }
        /// <summary>Default iOS Enrollment Profile</summary>
        public DepIOSEnrollmentProfile DefaultIosEnrollmentProfile { get; set; }
        /// <summary>Default MacOs Enrollment Profile</summary>
        public DepMacOSEnrollmentProfile DefaultMacOsEnrollmentProfile { get; set; }
        /// <summary>The enrollment profiles.</summary>
        public List<EnrollmentProfile> EnrollmentProfiles { get; set; }
        /// <summary>The imported Apple device identities.</summary>
        public List<ImportedAppleDeviceIdentity> ImportedAppleDeviceIdentities { get; set; }
        /// <summary>When the service was onboarded.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>When the service last syned with Intune</summary>
        public DateTimeOffset? LastSuccessfulSyncDateTime { get; set; }
        /// <summary>Error code reported by Apple during last dep sync.</summary>
        public int? LastSyncErrorCode { get; set; }
        /// <summary>When Intune last requested a sync.</summary>
        public DateTimeOffset? LastSyncTriggeredDateTime { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Whether or not the Dep token sharing is enabled with the School Data Sync service.</summary>
        public bool? ShareTokenWithSchoolDataSyncService { get; set; }
        /// <summary>Gets synced device count</summary>
        public int? SyncedDeviceCount { get; set; }
        /// <summary>When the token will expire.</summary>
        public DateTimeOffset? TokenExpirationDateTime { get; set; }
        /// <summary>Friendly Name for Dep Token</summary>
        public string TokenName { get; set; }
        /// <summary>Gets or sets the Dep Token Type. Possible values are: none, dep, appleSchoolManager.</summary>
        public DepTokenType? TokenType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DepOnboardingSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepOnboardingSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appleIdentifier", (o,n) => { (o as DepOnboardingSetting).AppleIdentifier = n.GetStringValue(); } },
                {"dataSharingConsentGranted", (o,n) => { (o as DepOnboardingSetting).DataSharingConsentGranted = n.GetBoolValue(); } },
                {"defaultIosEnrollmentProfile", (o,n) => { (o as DepOnboardingSetting).DefaultIosEnrollmentProfile = n.GetObjectValue<DepIOSEnrollmentProfile>(DepIOSEnrollmentProfile.CreateFromDiscriminatorValue); } },
                {"defaultMacOsEnrollmentProfile", (o,n) => { (o as DepOnboardingSetting).DefaultMacOsEnrollmentProfile = n.GetObjectValue<DepMacOSEnrollmentProfile>(DepMacOSEnrollmentProfile.CreateFromDiscriminatorValue); } },
                {"enrollmentProfiles", (o,n) => { (o as DepOnboardingSetting).EnrollmentProfiles = n.GetCollectionOfObjectValues<EnrollmentProfile>(EnrollmentProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"importedAppleDeviceIdentities", (o,n) => { (o as DepOnboardingSetting).ImportedAppleDeviceIdentities = n.GetCollectionOfObjectValues<ImportedAppleDeviceIdentity>(ImportedAppleDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DepOnboardingSetting).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSuccessfulSyncDateTime", (o,n) => { (o as DepOnboardingSetting).LastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncErrorCode", (o,n) => { (o as DepOnboardingSetting).LastSyncErrorCode = n.GetIntValue(); } },
                {"lastSyncTriggeredDateTime", (o,n) => { (o as DepOnboardingSetting).LastSyncTriggeredDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DepOnboardingSetting).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"shareTokenWithSchoolDataSyncService", (o,n) => { (o as DepOnboardingSetting).ShareTokenWithSchoolDataSyncService = n.GetBoolValue(); } },
                {"syncedDeviceCount", (o,n) => { (o as DepOnboardingSetting).SyncedDeviceCount = n.GetIntValue(); } },
                {"tokenExpirationDateTime", (o,n) => { (o as DepOnboardingSetting).TokenExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenName", (o,n) => { (o as DepOnboardingSetting).TokenName = n.GetStringValue(); } },
                {"tokenType", (o,n) => { (o as DepOnboardingSetting).TokenType = n.GetEnumValue<DepTokenType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleIdentifier", AppleIdentifier);
            writer.WriteBoolValue("dataSharingConsentGranted", DataSharingConsentGranted);
            writer.WriteObjectValue<DepIOSEnrollmentProfile>("defaultIosEnrollmentProfile", DefaultIosEnrollmentProfile);
            writer.WriteObjectValue<DepMacOSEnrollmentProfile>("defaultMacOsEnrollmentProfile", DefaultMacOsEnrollmentProfile);
            writer.WriteCollectionOfObjectValues<EnrollmentProfile>("enrollmentProfiles", EnrollmentProfiles);
            writer.WriteCollectionOfObjectValues<ImportedAppleDeviceIdentity>("importedAppleDeviceIdentities", ImportedAppleDeviceIdentities);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastSuccessfulSyncDateTime", LastSuccessfulSyncDateTime);
            writer.WriteIntValue("lastSyncErrorCode", LastSyncErrorCode);
            writer.WriteDateTimeOffsetValue("lastSyncTriggeredDateTime", LastSyncTriggeredDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("shareTokenWithSchoolDataSyncService", ShareTokenWithSchoolDataSyncService);
            writer.WriteIntValue("syncedDeviceCount", SyncedDeviceCount);
            writer.WriteDateTimeOffsetValue("tokenExpirationDateTime", TokenExpirationDateTime);
            writer.WriteStringValue("tokenName", TokenName);
            writer.WriteEnumValue<DepTokenType>("tokenType", TokenType);
        }
    }
}
