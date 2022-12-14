using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class StrongAuthenticationPhoneAppDetail : Entity, IParsable {
        /// <summary>The authenticationType property</summary>
        public string AuthenticationType {
            get { return BackingStore?.Get<string>("authenticationType"); }
            set { BackingStore?.Set("authenticationType", value); }
        }
        /// <summary>The authenticatorFlavor property</summary>
        public string AuthenticatorFlavor {
            get { return BackingStore?.Get<string>("authenticatorFlavor"); }
            set { BackingStore?.Set("authenticatorFlavor", value); }
        }
        /// <summary>The deviceId property</summary>
        public Guid? DeviceId {
            get { return BackingStore?.Get<Guid?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The deviceName property</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>The deviceTag property</summary>
        public string DeviceTag {
            get { return BackingStore?.Get<string>("deviceTag"); }
            set { BackingStore?.Set("deviceTag", value); }
        }
        /// <summary>The deviceToken property</summary>
        public string DeviceToken {
            get { return BackingStore?.Get<string>("deviceToken"); }
            set { BackingStore?.Set("deviceToken", value); }
        }
        /// <summary>The hashFunction property</summary>
        public string HashFunction {
            get { return BackingStore?.Get<string>("hashFunction"); }
            set { BackingStore?.Set("hashFunction", value); }
        }
        /// <summary>The lastAuthenticatedDateTime property</summary>
        public DateTimeOffset? LastAuthenticatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastAuthenticatedDateTime"); }
            set { BackingStore?.Set("lastAuthenticatedDateTime", value); }
        }
        /// <summary>The notificationType property</summary>
        public string NotificationType {
            get { return BackingStore?.Get<string>("notificationType"); }
            set { BackingStore?.Set("notificationType", value); }
        }
        /// <summary>The oathSecretKey property</summary>
        public string OathSecretKey {
            get { return BackingStore?.Get<string>("oathSecretKey"); }
            set { BackingStore?.Set("oathSecretKey", value); }
        }
        /// <summary>The oathTokenMetadata property</summary>
        public Microsoft.Graph.Beta.Models.OathTokenMetadata OathTokenMetadata {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OathTokenMetadata>("oathTokenMetadata"); }
            set { BackingStore?.Set("oathTokenMetadata", value); }
        }
        /// <summary>The oathTokenTimeDriftInSeconds property</summary>
        public int? OathTokenTimeDriftInSeconds {
            get { return BackingStore?.Get<int?>("oathTokenTimeDriftInSeconds"); }
            set { BackingStore?.Set("oathTokenTimeDriftInSeconds", value); }
        }
        /// <summary>The phoneAppVersion property</summary>
        public string PhoneAppVersion {
            get { return BackingStore?.Get<string>("phoneAppVersion"); }
            set { BackingStore?.Set("phoneAppVersion", value); }
        }
        /// <summary>The tenantDeviceId property</summary>
        public string TenantDeviceId {
            get { return BackingStore?.Get<string>("tenantDeviceId"); }
            set { BackingStore?.Set("tenantDeviceId", value); }
        }
        /// <summary>The tokenGenerationIntervalInSeconds property</summary>
        public int? TokenGenerationIntervalInSeconds {
            get { return BackingStore?.Get<int?>("tokenGenerationIntervalInSeconds"); }
            set { BackingStore?.Set("tokenGenerationIntervalInSeconds", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"deviceId", n => { DeviceId = n.GetGuidValue(); } },
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("authenticationType", AuthenticationType);
            writer.WriteStringValue("authenticatorFlavor", AuthenticatorFlavor);
            writer.WriteGuidValue("deviceId", DeviceId);
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
