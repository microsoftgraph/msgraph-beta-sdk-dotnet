using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Enrollment Profile used to enroll Android Enterprise devices using Google&apos;s Cloud Management.</summary>
    public class AndroidDeviceOwnerEnrollmentProfile : Entity, IParsable {
        /// <summary>Tenant GUID the enrollment profile belongs to.</summary>
        public string AccountId {
            get { return BackingStore?.Get<string>(nameof(AccountId)); }
            set { BackingStore?.Set(nameof(AccountId), value); }
        }
        /// <summary>Date time the enrollment profile was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Description for the enrollment profile.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Display name for the enrollment profile.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Total number of Android devices that have enrolled using this enrollment profile.</summary>
        public int? EnrolledDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(EnrolledDeviceCount)); }
            set { BackingStore?.Set(nameof(EnrolledDeviceCount), value); }
        }
        /// <summary>The enrollment mode of devices that use this enrollment profile. Possible values are: corporateOwnedDedicatedDevice, corporateOwnedFullyManaged, corporateOwnedWorkProfile, corporateOwnedAOSPUserlessDevice, corporateOwnedAOSPUserAssociatedDevice.</summary>
        public AndroidDeviceOwnerEnrollmentMode? EnrollmentMode {
            get { return BackingStore?.Get<AndroidDeviceOwnerEnrollmentMode?>(nameof(EnrollmentMode)); }
            set { BackingStore?.Set(nameof(EnrollmentMode), value); }
        }
        /// <summary>The enrollment token type for an enrollment profile. Possible values are: default, corporateOwnedDedicatedDeviceWithAzureADSharedMode.</summary>
        public AndroidDeviceOwnerEnrollmentTokenType? EnrollmentTokenType {
            get { return BackingStore?.Get<AndroidDeviceOwnerEnrollmentTokenType?>(nameof(EnrollmentTokenType)); }
            set { BackingStore?.Set(nameof(EnrollmentTokenType), value); }
        }
        /// <summary>Total number of AOSP devices that have enrolled using the current token.</summary>
        public int? EnrollmentTokenUsageCount {
            get { return BackingStore?.Get<int?>(nameof(EnrollmentTokenUsageCount)); }
            set { BackingStore?.Set(nameof(EnrollmentTokenUsageCount), value); }
        }
        /// <summary>Date time the enrollment profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>String used to generate a QR code for the token.</summary>
        public string QrCodeContent {
            get { return BackingStore?.Get<string>(nameof(QrCodeContent)); }
            set { BackingStore?.Set(nameof(QrCodeContent), value); }
        }
        /// <summary>String used to generate a QR code for the token.</summary>
        public MimeContent QrCodeImage {
            get { return BackingStore?.Get<MimeContent>(nameof(QrCodeImage)); }
            set { BackingStore?.Set(nameof(QrCodeImage), value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(RoleScopeTagIds)); }
            set { BackingStore?.Set(nameof(RoleScopeTagIds), value); }
        }
        /// <summary>Date time the most recently created token was created.</summary>
        public DateTimeOffset? TokenCreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(TokenCreationDateTime)); }
            set { BackingStore?.Set(nameof(TokenCreationDateTime), value); }
        }
        /// <summary>Date time the most recently created token will expire.</summary>
        public DateTimeOffset? TokenExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(TokenExpirationDateTime)); }
            set { BackingStore?.Set(nameof(TokenExpirationDateTime), value); }
        }
        /// <summary>Value of the most recently created token for this enrollment profile.</summary>
        public string TokenValue {
            get { return BackingStore?.Get<string>(nameof(TokenValue)); }
            set { BackingStore?.Set(nameof(TokenValue), value); }
        }
        /// <summary>Boolean that indicates if hidden wifi networks are enabled</summary>
        public bool? WifiHidden {
            get { return BackingStore?.Get<bool?>(nameof(WifiHidden)); }
            set { BackingStore?.Set(nameof(WifiHidden), value); }
        }
        /// <summary>String that contains the wi-fi login password</summary>
        public string WifiPassword {
            get { return BackingStore?.Get<string>(nameof(WifiPassword)); }
            set { BackingStore?.Set(nameof(WifiPassword), value); }
        }
        /// <summary>String that contains the wi-fi security type. Possible values are: none, wpa, wep.</summary>
        public AospWifiSecurityType? WifiSecurityType {
            get { return BackingStore?.Get<AospWifiSecurityType?>(nameof(WifiSecurityType)); }
            set { BackingStore?.Set(nameof(WifiSecurityType), value); }
        }
        /// <summary>String that contains the wi-fi login ssid</summary>
        public string WifiSsid {
            get { return BackingStore?.Get<string>(nameof(WifiSsid)); }
            set { BackingStore?.Set(nameof(WifiSsid), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceOwnerEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrolledDeviceCount", n => { EnrolledDeviceCount = n.GetIntValue(); } },
                {"enrollmentMode", n => { EnrollmentMode = n.GetEnumValue<AndroidDeviceOwnerEnrollmentMode>(); } },
                {"enrollmentTokenType", n => { EnrollmentTokenType = n.GetEnumValue<AndroidDeviceOwnerEnrollmentTokenType>(); } },
                {"enrollmentTokenUsageCount", n => { EnrollmentTokenUsageCount = n.GetIntValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"qrCodeContent", n => { QrCodeContent = n.GetStringValue(); } },
                {"qrCodeImage", n => { QrCodeImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tokenCreationDateTime", n => { TokenCreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenExpirationDateTime", n => { TokenExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenValue", n => { TokenValue = n.GetStringValue(); } },
                {"wifiHidden", n => { WifiHidden = n.GetBoolValue(); } },
                {"wifiPassword", n => { WifiPassword = n.GetStringValue(); } },
                {"wifiSecurityType", n => { WifiSecurityType = n.GetEnumValue<AospWifiSecurityType>(); } },
                {"wifiSsid", n => { WifiSsid = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteEnumValue<AndroidDeviceOwnerEnrollmentMode>("enrollmentMode", EnrollmentMode);
            writer.WriteEnumValue<AndroidDeviceOwnerEnrollmentTokenType>("enrollmentTokenType", EnrollmentTokenType);
            writer.WriteIntValue("enrollmentTokenUsageCount", EnrollmentTokenUsageCount);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("qrCodeContent", QrCodeContent);
            writer.WriteObjectValue<MimeContent>("qrCodeImage", QrCodeImage);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteDateTimeOffsetValue("tokenCreationDateTime", TokenCreationDateTime);
            writer.WriteDateTimeOffsetValue("tokenExpirationDateTime", TokenExpirationDateTime);
            writer.WriteStringValue("tokenValue", TokenValue);
            writer.WriteBoolValue("wifiHidden", WifiHidden);
            writer.WriteStringValue("wifiPassword", WifiPassword);
            writer.WriteEnumValue<AospWifiSecurityType>("wifiSecurityType", WifiSecurityType);
            writer.WriteStringValue("wifiSsid", WifiSsid);
        }
    }
}
