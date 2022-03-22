using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementDerivedCredentialSettings : Entity, IParsable {
        /// <summary>The display name for the profile.</summary>
        public string DisplayName { get; set; }
        /// <summary>The URL that will be accessible to end users as they retrieve a derived credential using the Company Portal.</summary>
        public string HelpUrl { get; set; }
        /// <summary>The derived credential provider to use.</summary>
        public DeviceManagementDerivedCredentialIssuer? Issuer { get; set; }
        /// <summary>The methods used to inform the end user to open Company Portal to deliver Wi-Fi, VPN, or email profiles that use certificates to the device.</summary>
        public DeviceManagementDerivedCredentialNotificationType? NotificationType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementDerivedCredentialSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementDerivedCredentialSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as DeviceManagementDerivedCredentialSettings).DisplayName = n.GetStringValue(); } },
                {"helpUrl", (o,n) => { (o as DeviceManagementDerivedCredentialSettings).HelpUrl = n.GetStringValue(); } },
                {"issuer", (o,n) => { (o as DeviceManagementDerivedCredentialSettings).Issuer = n.GetEnumValue<DeviceManagementDerivedCredentialIssuer>(); } },
                {"notificationType", (o,n) => { (o as DeviceManagementDerivedCredentialSettings).NotificationType = n.GetEnumValue<DeviceManagementDerivedCredentialNotificationType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpUrl", HelpUrl);
            writer.WriteEnumValue<DeviceManagementDerivedCredentialIssuer>("issuer", Issuer);
            writer.WriteEnumValue<DeviceManagementDerivedCredentialNotificationType>("notificationType", NotificationType);
        }
    }
}
