using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkWiFiConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.</summary>
        public bool? ConnectAutomatically {
            get { return BackingStore?.Get<bool?>(nameof(ConnectAutomatically)); }
            set { BackingStore?.Set(nameof(ConnectAutomatically), value); }
        }
        /// <summary>When set to true, this profile forces the device to connect to a network that doesn&apos;t broadcast its SSID to all devices.</summary>
        public bool? ConnectWhenNetworkNameIsHidden {
            get { return BackingStore?.Get<bool?>(nameof(ConnectWhenNetworkNameIsHidden)); }
            set { BackingStore?.Set(nameof(ConnectWhenNetworkNameIsHidden), value); }
        }
        /// <summary>Network Name</summary>
        public string NetworkName {
            get { return BackingStore?.Get<string>(nameof(NetworkName)); }
            set { BackingStore?.Set(nameof(NetworkName), value); }
        }
        /// <summary>This is the name of the Wi-Fi network that is broadcast to all devices.</summary>
        public string Ssid {
            get { return BackingStore?.Get<string>(nameof(Ssid)); }
            set { BackingStore?.Set(nameof(Ssid), value); }
        }
        /// <summary>Indicates whether Wi-Fi endpoint uses an EAP based security type. Possible values are: open, wpaEnterprise, wpa2Enterprise.</summary>
        public AndroidWiFiSecurityType? WiFiSecurityType {
            get { return BackingStore?.Get<AndroidWiFiSecurityType?>(nameof(WiFiSecurityType)); }
            set { BackingStore?.Set(nameof(WiFiSecurityType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidForWorkWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidForWorkEnterpriseWiFiConfiguration" => new AndroidForWorkEnterpriseWiFiConfiguration(),
                _ => new AndroidForWorkWiFiConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectAutomatically", n => { ConnectAutomatically = n.GetBoolValue(); } },
                {"connectWhenNetworkNameIsHidden", n => { ConnectWhenNetworkNameIsHidden = n.GetBoolValue(); } },
                {"networkName", n => { NetworkName = n.GetStringValue(); } },
                {"ssid", n => { Ssid = n.GetStringValue(); } },
                {"wiFiSecurityType", n => { WiFiSecurityType = n.GetEnumValue<AndroidWiFiSecurityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("connectAutomatically", ConnectAutomatically);
            writer.WriteBoolValue("connectWhenNetworkNameIsHidden", ConnectWhenNetworkNameIsHidden);
            writer.WriteStringValue("networkName", NetworkName);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<AndroidWiFiSecurityType>("wiFiSecurityType", WiFiSecurityType);
        }
    }
}
