using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AospDeviceOwnerWiFiConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.</summary>
        public bool? ConnectAutomatically {
            get { return BackingStore?.Get<bool?>("connectAutomatically"); }
            set { BackingStore?.Set("connectAutomatically", value); }
        }
        /// <summary>When set to true, this profile forces the device to connect to a network that doesn&apos;t broadcast its SSID to all devices.</summary>
        public bool? ConnectWhenNetworkNameIsHidden {
            get { return BackingStore?.Get<bool?>("connectWhenNetworkNameIsHidden"); }
            set { BackingStore?.Set("connectWhenNetworkNameIsHidden", value); }
        }
        /// <summary>Network Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkName {
            get { return BackingStore?.Get<string?>("networkName"); }
            set { BackingStore?.Set("networkName", value); }
        }
#nullable restore
#else
        public string NetworkName {
            get { return BackingStore?.Get<string>("networkName"); }
            set { BackingStore?.Set("networkName", value); }
        }
#endif
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreSharedKey {
            get { return BackingStore?.Get<string?>("preSharedKey"); }
            set { BackingStore?.Set("preSharedKey", value); }
        }
#nullable restore
#else
        public string PreSharedKey {
            get { return BackingStore?.Get<string>("preSharedKey"); }
            set { BackingStore?.Set("preSharedKey", value); }
        }
#endif
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public bool? PreSharedKeyIsSet {
            get { return BackingStore?.Get<bool?>("preSharedKeyIsSet"); }
            set { BackingStore?.Set("preSharedKeyIsSet", value); }
        }
        /// <summary>This is the name of the Wi-Fi network that is broadcast to all devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ssid {
            get { return BackingStore?.Get<string?>("ssid"); }
            set { BackingStore?.Set("ssid", value); }
        }
#nullable restore
#else
        public string Ssid {
            get { return BackingStore?.Get<string>("ssid"); }
            set { BackingStore?.Set("ssid", value); }
        }
#endif
        /// <summary>Wi-Fi Security Types for AOSP Device Owner.</summary>
        public AospDeviceOwnerWiFiSecurityType? WiFiSecurityType {
            get { return BackingStore?.Get<AospDeviceOwnerWiFiSecurityType?>("wiFiSecurityType"); }
            set { BackingStore?.Set("wiFiSecurityType", value); }
        }
        /// <summary>
        /// Instantiates a new AospDeviceOwnerWiFiConfiguration and sets the default values.
        /// </summary>
        public AospDeviceOwnerWiFiConfiguration() : base() {
            OdataType = "#microsoft.graph.aospDeviceOwnerWiFiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AospDeviceOwnerWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.aospDeviceOwnerEnterpriseWiFiConfiguration" => new AospDeviceOwnerEnterpriseWiFiConfiguration(),
                _ => new AospDeviceOwnerWiFiConfiguration(),
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
                {"preSharedKey", n => { PreSharedKey = n.GetStringValue(); } },
                {"preSharedKeyIsSet", n => { PreSharedKeyIsSet = n.GetBoolValue(); } },
                {"ssid", n => { Ssid = n.GetStringValue(); } },
                {"wiFiSecurityType", n => { WiFiSecurityType = n.GetEnumValue<AospDeviceOwnerWiFiSecurityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("connectAutomatically", ConnectAutomatically);
            writer.WriteBoolValue("connectWhenNetworkNameIsHidden", ConnectWhenNetworkNameIsHidden);
            writer.WriteStringValue("networkName", NetworkName);
            writer.WriteStringValue("preSharedKey", PreSharedKey);
            writer.WriteBoolValue("preSharedKeyIsSet", PreSharedKeyIsSet);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<AospDeviceOwnerWiFiSecurityType>("wiFiSecurityType", WiFiSecurityType);
        }
    }
}
