using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AndroidDeviceOwnerEnrollmentProfile : Entity, IParsable {
        /// <summary>Tenant GUID the enrollment profile belongs to.</summary>
        public string AccountId { get; set; }
        /// <summary>Date time the enrollment profile was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description for the enrollment profile.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the enrollment profile.</summary>
        public string DisplayName { get; set; }
        /// <summary>Total number of Android devices that have enrolled using this enrollment profile.</summary>
        public int? EnrolledDeviceCount { get; set; }
        /// <summary>The enrollment mode of devices that use this enrollment profile. Possible values are: corporateOwnedDedicatedDevice, corporateOwnedFullyManaged, corporateOwnedWorkProfile, corporateOwnedAOSPUserlessDevice, corporateOwnedAOSPUserAssociatedDevice.</summary>
        public AndroidDeviceOwnerEnrollmentMode? EnrollmentMode { get; set; }
        /// <summary>The enrollment token type for an enrollment profile. Possible values are: default, corporateOwnedDedicatedDeviceWithAzureADSharedMode.</summary>
        public AndroidDeviceOwnerEnrollmentTokenType? EnrollmentTokenType { get; set; }
        /// <summary>Total number of AOSP devices that have enrolled using the current token.</summary>
        public int? EnrollmentTokenUsageCount { get; set; }
        /// <summary>Date time the enrollment profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>String used to generate a QR code for the token.</summary>
        public string QrCodeContent { get; set; }
        /// <summary>String used to generate a QR code for the token.</summary>
        public MimeContent QrCodeImage { get; set; }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Date time the most recently created token was created.</summary>
        public DateTimeOffset? TokenCreationDateTime { get; set; }
        /// <summary>Date time the most recently created token will expire.</summary>
        public DateTimeOffset? TokenExpirationDateTime { get; set; }
        /// <summary>Value of the most recently created token for this enrollment profile.</summary>
        public string TokenValue { get; set; }
        /// <summary>Boolean that indicates if hidden wifi networks are enabled</summary>
        public bool? WifiHidden { get; set; }
        /// <summary>String that contains the wi-fi login password</summary>
        public string WifiPassword { get; set; }
        /// <summary>String that contains the wi-fi security type. Possible values are: none, wpa, wep.</summary>
        public AospWifiSecurityType? WifiSecurityType { get; set; }
        /// <summary>String that contains the wi-fi login ssid</summary>
        public string WifiSsid { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accountId", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).AccountId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).DisplayName = n.GetStringValue(); } },
                {"enrolledDeviceCount", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).EnrolledDeviceCount = n.GetIntValue(); } },
                {"enrollmentMode", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).EnrollmentMode = n.GetEnumValue<AndroidDeviceOwnerEnrollmentMode>(); } },
                {"enrollmentTokenType", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).EnrollmentTokenType = n.GetEnumValue<AndroidDeviceOwnerEnrollmentTokenType>(); } },
                {"enrollmentTokenUsageCount", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).EnrollmentTokenUsageCount = n.GetIntValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"qrCodeContent", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).QrCodeContent = n.GetStringValue(); } },
                {"qrCodeImage", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).QrCodeImage = n.GetObjectValue<MimeContent>(); } },
                {"roleScopeTagIds", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tokenCreationDateTime", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).TokenCreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenExpirationDateTime", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).TokenExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenValue", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).TokenValue = n.GetStringValue(); } },
                {"wifiHidden", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).WifiHidden = n.GetBoolValue(); } },
                {"wifiPassword", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).WifiPassword = n.GetStringValue(); } },
                {"wifiSecurityType", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).WifiSecurityType = n.GetEnumValue<AospWifiSecurityType>(); } },
                {"wifiSsid", (o,n) => { (o as AndroidDeviceOwnerEnrollmentProfile).WifiSsid = n.GetStringValue(); } },
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
