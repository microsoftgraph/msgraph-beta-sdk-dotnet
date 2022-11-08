using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosWiFiConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.</summary>
        public bool? ConnectAutomatically {
            get { return BackingStore?.Get<bool?>("connectAutomatically"); }
            set { BackingStore?.Set("connectAutomatically", value); }
        }
        /// <summary>Connect when the network is not broadcasting its name (SSID). When set to true, this profile forces the device to connect to a network that doesn&apos;t broadcast its SSID to all devices.</summary>
        public bool? ConnectWhenNetworkNameIsHidden {
            get { return BackingStore?.Get<bool?>("connectWhenNetworkNameIsHidden"); }
            set { BackingStore?.Set("connectWhenNetworkNameIsHidden", value); }
        }
        /// <summary>If set to true, forces devices connecting using this Wi-Fi profile to present their actual Wi-Fi MAC address instead of a random MAC address. Applies to iOS 14 and later.</summary>
        public bool? DisableMacAddressRandomization {
            get { return BackingStore?.Get<bool?>("disableMacAddressRandomization"); }
            set { BackingStore?.Set("disableMacAddressRandomization", value); }
        }
        /// <summary>Network Name</summary>
        public string NetworkName {
            get { return BackingStore?.Get<string>("networkName"); }
            set { BackingStore?.Set("networkName", value); }
        }
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public string PreSharedKey {
            get { return BackingStore?.Get<string>("preSharedKey"); }
            set { BackingStore?.Set("preSharedKey", value); }
        }
        /// <summary>URL of the proxy server automatic configuration script when automatic configuration is selected. This URL is typically the location of PAC (Proxy Auto Configuration) file.</summary>
        public string ProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string>("proxyAutomaticConfigurationUrl"); }
            set { BackingStore?.Set("proxyAutomaticConfigurationUrl", value); }
        }
        /// <summary>IP Address or DNS hostname of the proxy server when manual configuration is selected.</summary>
        public string ProxyManualAddress {
            get { return BackingStore?.Get<string>("proxyManualAddress"); }
            set { BackingStore?.Set("proxyManualAddress", value); }
        }
        /// <summary>Port of the proxy server when manual configuration is selected.</summary>
        public int? ProxyManualPort {
            get { return BackingStore?.Get<int?>("proxyManualPort"); }
            set { BackingStore?.Set("proxyManualPort", value); }
        }
        /// <summary>Wi-Fi Proxy Settings.</summary>
        public WiFiProxySetting? ProxySettings {
            get { return BackingStore?.Get<WiFiProxySetting?>("proxySettings"); }
            set { BackingStore?.Set("proxySettings", value); }
        }
        /// <summary>This is the name of the Wi-Fi network that is broadcast to all devices.</summary>
        public string Ssid {
            get { return BackingStore?.Get<string>("ssid"); }
            set { BackingStore?.Set("ssid", value); }
        }
        /// <summary>Wi-Fi Security Types.</summary>
        public Microsoft.Graph.Beta.Models.WiFiSecurityType? WiFiSecurityType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WiFiSecurityType?>("wiFiSecurityType"); }
            set { BackingStore?.Set("wiFiSecurityType", value); }
        }
        /// <summary>
        /// Instantiates a new IosWiFiConfiguration and sets the default values.
        /// </summary>
        public IosWiFiConfiguration() : base() {
            OdataType = "#microsoft.graph.iosWiFiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosEnterpriseWiFiConfiguration" => new IosEnterpriseWiFiConfiguration(),
                _ => new IosWiFiConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectAutomatically", n => { ConnectAutomatically = n.GetBoolValue(); } },
                {"connectWhenNetworkNameIsHidden", n => { ConnectWhenNetworkNameIsHidden = n.GetBoolValue(); } },
                {"disableMacAddressRandomization", n => { DisableMacAddressRandomization = n.GetBoolValue(); } },
                {"networkName", n => { NetworkName = n.GetStringValue(); } },
                {"preSharedKey", n => { PreSharedKey = n.GetStringValue(); } },
                {"proxyAutomaticConfigurationUrl", n => { ProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                {"proxyManualAddress", n => { ProxyManualAddress = n.GetStringValue(); } },
                {"proxyManualPort", n => { ProxyManualPort = n.GetIntValue(); } },
                {"proxySettings", n => { ProxySettings = n.GetEnumValue<WiFiProxySetting>(); } },
                {"ssid", n => { Ssid = n.GetStringValue(); } },
                {"wiFiSecurityType", n => { WiFiSecurityType = n.GetEnumValue<WiFiSecurityType>(); } },
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
            writer.WriteBoolValue("disableMacAddressRandomization", DisableMacAddressRandomization);
            writer.WriteStringValue("networkName", NetworkName);
            writer.WriteStringValue("preSharedKey", PreSharedKey);
            writer.WriteStringValue("proxyAutomaticConfigurationUrl", ProxyAutomaticConfigurationUrl);
            writer.WriteStringValue("proxyManualAddress", ProxyManualAddress);
            writer.WriteIntValue("proxyManualPort", ProxyManualPort);
            writer.WriteEnumValue<WiFiProxySetting>("proxySettings", ProxySettings);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<WiFiSecurityType>("wiFiSecurityType", WiFiSecurityType);
        }
    }
}
