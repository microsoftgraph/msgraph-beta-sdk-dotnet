using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class StrongAuthenticationPhoneAppDetail : Entity, IParsable {
        /// <summary>The authenticationType property</summary>
        public string AuthenticationType {
            get { return BackingStore?.Get<string>(nameof(AuthenticationType)); }
            set { BackingStore?.Set(nameof(AuthenticationType), value); }
        }
        /// <summary>The authenticatorFlavor property</summary>
        public string AuthenticatorFlavor {
            get { return BackingStore?.Get<string>(nameof(AuthenticatorFlavor)); }
            set { BackingStore?.Set(nameof(AuthenticatorFlavor), value); }
        }
        /// <summary>The deviceId property</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>The deviceName property</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>The deviceTag property</summary>
        public string DeviceTag {
            get { return BackingStore?.Get<string>(nameof(DeviceTag)); }
            set { BackingStore?.Set(nameof(DeviceTag), value); }
        }
        /// <summary>The deviceToken property</summary>
        public string DeviceToken {
            get { return BackingStore?.Get<string>(nameof(DeviceToken)); }
            set { BackingStore?.Set(nameof(DeviceToken), value); }
        }
        /// <summary>The hashFunction property</summary>
        public string HashFunction {
            get { return BackingStore?.Get<string>(nameof(HashFunction)); }
            set { BackingStore?.Set(nameof(HashFunction), value); }
        }
        /// <summary>The lastAuthenticatedDateTime property</summary>
        public DateTimeOffset? LastAuthenticatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastAuthenticatedDateTime)); }
            set { BackingStore?.Set(nameof(LastAuthenticatedDateTime), value); }
        }
        /// <summary>The notificationType property</summary>
        public string NotificationType {
            get { return BackingStore?.Get<string>(nameof(NotificationType)); }
            set { BackingStore?.Set(nameof(NotificationType), value); }
        }
        /// <summary>The oathSecretKey property</summary>
        public string OathSecretKey {
            get { return BackingStore?.Get<string>(nameof(OathSecretKey)); }
            set { BackingStore?.Set(nameof(OathSecretKey), value); }
        }
        /// <summary>The oathTokenMetadata property</summary>
        public Microsoft.Graph.Beta.Models.OathTokenMetadata OathTokenMetadata {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OathTokenMetadata>(nameof(OathTokenMetadata)); }
            set { BackingStore?.Set(nameof(OathTokenMetadata), value); }
        }
        /// <summary>The oathTokenTimeDriftInSeconds property</summary>
        public int? OathTokenTimeDriftInSeconds {
            get { return BackingStore?.Get<int?>(nameof(OathTokenTimeDriftInSeconds)); }
            set { BackingStore?.Set(nameof(OathTokenTimeDriftInSeconds), value); }
        }
        /// <summary>The phoneAppVersion property</summary>
        public string PhoneAppVersion {
            get { return BackingStore?.Get<string>(nameof(PhoneAppVersion)); }
            set { BackingStore?.Set(nameof(PhoneAppVersion), value); }
        }
        /// <summary>The tenantDeviceId property</summary>
        public string TenantDeviceId {
            get { return BackingStore?.Get<string>(nameof(TenantDeviceId)); }
            set { BackingStore?.Set(nameof(TenantDeviceId), value); }
        }
        /// <summary>The tokenGenerationIntervalInSeconds property</summary>
        public int? TokenGenerationIntervalInSeconds {
            get { return BackingStore?.Get<int?>(nameof(TokenGenerationIntervalInSeconds)); }
            set { BackingStore?.Set(nameof(TokenGenerationIntervalInSeconds), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new StrongAuthenticationPhoneAppDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StrongAuthenticationPhoneAppDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationType", n => { AuthenticationType = n.GetStringValue(); } },
                {"authenticatorFlavor", n => { AuthenticatorFlavor = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceTag", n => { DeviceTag = n.GetStringValue(); } },
                {"deviceToken", n => { DeviceToken = n.GetStringValue(); } },
                {"hashFunction", n => { HashFunction = n.GetStringValue(); } },
                {"lastAuthenticatedDateTime", n => { LastAuthenticatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notificationType", n => { NotificationType = n.GetStringValue(); } },
                {"oathSecretKey", n => { OathSecretKey = n.GetStringValue(); } },
                {"oathTokenMetadata", n => { OathTokenMetadata = n.GetObjectValue<Microsoft.Graph.Beta.Models.OathTokenMetadata>(Microsoft.Graph.Beta.Models.OathTokenMetadata.CreateFromDiscriminatorValue); } },
                {"oathTokenTimeDriftInSeconds", n => { OathTokenTimeDriftInSeconds = n.GetIntValue(); } },
                {"phoneAppVersion", n => { PhoneAppVersion = n.GetStringValue(); } },
                {"tenantDeviceId", n => { TenantDeviceId = n.GetStringValue(); } },
                {"tokenGenerationIntervalInSeconds", n => { TokenGenerationIntervalInSeconds = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("authenticationType", AuthenticationType);
            writer.WriteStringValue("authenticatorFlavor", AuthenticatorFlavor);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("deviceToken", DeviceToken);
            writer.WriteStringValue("hashFunction", HashFunction);
            writer.WriteDateTimeOffsetValue("lastAuthenticatedDateTime", LastAuthenticatedDateTime);
            writer.WriteStringValue("notificationType", NotificationType);
            writer.WriteStringValue("oathSecretKey", OathSecretKey);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.OathTokenMetadata>("oathTokenMetadata", OathTokenMetadata);
            writer.WriteIntValue("oathTokenTimeDriftInSeconds", OathTokenTimeDriftInSeconds);
            writer.WriteStringValue("phoneAppVersion", PhoneAppVersion);
            writer.WriteStringValue("tenantDeviceId", TenantDeviceId);
            writer.WriteIntValue("tokenGenerationIntervalInSeconds", TokenGenerationIntervalInSeconds);
        }
    }
}
