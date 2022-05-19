using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The depOnboardingSetting represents an instance of the Apple DEP service being onboarded to Intune. The onboarded service instance manages an Apple Token used to synchronize data between Apple and Intune.</summary>
    public class DepOnboardingSetting : Entity, IParsable {
        /// <summary>The Apple ID used to obtain the current token.</summary>
        public string AppleIdentifier {
            get { return BackingStore?.Get<string>(nameof(AppleIdentifier)); }
            set { BackingStore?.Set(nameof(AppleIdentifier), value); }
        }
        /// <summary>Consent granted for data sharing with Apple Dep Service</summary>
        public bool? DataSharingConsentGranted {
            get { return BackingStore?.Get<bool?>(nameof(DataSharingConsentGranted)); }
            set { BackingStore?.Set(nameof(DataSharingConsentGranted), value); }
        }
        /// <summary>Default iOS Enrollment Profile</summary>
        public DepIOSEnrollmentProfile DefaultIosEnrollmentProfile {
            get { return BackingStore?.Get<DepIOSEnrollmentProfile>(nameof(DefaultIosEnrollmentProfile)); }
            set { BackingStore?.Set(nameof(DefaultIosEnrollmentProfile), value); }
        }
        /// <summary>Default MacOs Enrollment Profile</summary>
        public DepMacOSEnrollmentProfile DefaultMacOsEnrollmentProfile {
            get { return BackingStore?.Get<DepMacOSEnrollmentProfile>(nameof(DefaultMacOsEnrollmentProfile)); }
            set { BackingStore?.Set(nameof(DefaultMacOsEnrollmentProfile), value); }
        }
        /// <summary>The enrollment profiles.</summary>
        public List<EnrollmentProfile> EnrollmentProfiles {
            get { return BackingStore?.Get<List<EnrollmentProfile>>(nameof(EnrollmentProfiles)); }
            set { BackingStore?.Set(nameof(EnrollmentProfiles), value); }
        }
        /// <summary>The imported Apple device identities.</summary>
        public List<ImportedAppleDeviceIdentity> ImportedAppleDeviceIdentities {
            get { return BackingStore?.Get<List<ImportedAppleDeviceIdentity>>(nameof(ImportedAppleDeviceIdentities)); }
            set { BackingStore?.Set(nameof(ImportedAppleDeviceIdentities), value); }
        }
        /// <summary>When the service was onboarded.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>When the service last syned with Intune</summary>
        public DateTimeOffset? LastSuccessfulSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSuccessfulSyncDateTime)); }
            set { BackingStore?.Set(nameof(LastSuccessfulSyncDateTime), value); }
        }
        /// <summary>Error code reported by Apple during last dep sync.</summary>
        public int? LastSyncErrorCode {
            get { return BackingStore?.Get<int?>(nameof(LastSyncErrorCode)); }
            set { BackingStore?.Set(nameof(LastSyncErrorCode), value); }
        }
        /// <summary>When Intune last requested a sync.</summary>
        public DateTimeOffset? LastSyncTriggeredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSyncTriggeredDateTime)); }
            set { BackingStore?.Set(nameof(LastSyncTriggeredDateTime), value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>Whether or not the Dep token sharing is enabled with the School Data Sync service.</summary>
        public bool? ShareTokenWithSchoolDataSyncService {
            get { return BackingStore?.Get<bool?>(nameof(ShareTokenWithSchoolDataSyncService)); }
            set { BackingStore?.Set(nameof(ShareTokenWithSchoolDataSyncService), value); }
        }
        /// <summary>Gets synced device count</summary>
        public int? SyncedDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(SyncedDeviceCount)); }
            set { BackingStore?.Set(nameof(SyncedDeviceCount), value); }
        }
        /// <summary>When the token will expire.</summary>
        public DateTimeOffset? TokenExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(TokenExpirationDateTime)); }
            set { BackingStore?.Set(nameof(TokenExpirationDateTime), value); }
        }
        /// <summary>Friendly Name for Dep Token</summary>
        public string TokenName {
            get { return BackingStore?.Get<string>(nameof(TokenName)); }
            set { BackingStore?.Set(nameof(TokenName), value); }
        }
        /// <summary>Gets or sets the Dep Token Type. Possible values are: none, dep, appleSchoolManager.</summary>
        public DepTokenType? TokenType {
            get { return BackingStore?.Get<DepTokenType?>(nameof(TokenType)); }
            set { BackingStore?.Set(nameof(TokenType), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleIdentifier", n => { AppleIdentifier = n.GetStringValue(); } },
                {"dataSharingConsentGranted", n => { DataSharingConsentGranted = n.GetBoolValue(); } },
                {"defaultIosEnrollmentProfile", n => { DefaultIosEnrollmentProfile = n.GetObjectValue<DepIOSEnrollmentProfile>(DepIOSEnrollmentProfile.CreateFromDiscriminatorValue); } },
                {"defaultMacOsEnrollmentProfile", n => { DefaultMacOsEnrollmentProfile = n.GetObjectValue<DepMacOSEnrollmentProfile>(DepMacOSEnrollmentProfile.CreateFromDiscriminatorValue); } },
                {"enrollmentProfiles", n => { EnrollmentProfiles = n.GetCollectionOfObjectValues<EnrollmentProfile>(EnrollmentProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"importedAppleDeviceIdentities", n => { ImportedAppleDeviceIdentities = n.GetCollectionOfObjectValues<ImportedAppleDeviceIdentity>(ImportedAppleDeviceIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSuccessfulSyncDateTime", n => { LastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncErrorCode", n => { LastSyncErrorCode = n.GetIntValue(); } },
                {"lastSyncTriggeredDateTime", n => { LastSyncTriggeredDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"shareTokenWithSchoolDataSyncService", n => { ShareTokenWithSchoolDataSyncService = n.GetBoolValue(); } },
                {"syncedDeviceCount", n => { SyncedDeviceCount = n.GetIntValue(); } },
                {"tokenExpirationDateTime", n => { TokenExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenName", n => { TokenName = n.GetStringValue(); } },
                {"tokenType", n => { TokenType = n.GetEnumValue<DepTokenType>(); } },
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
