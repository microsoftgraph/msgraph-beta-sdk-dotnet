using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceOwnerWiFiConfiguration : DeviceConfiguration, IParsable {
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
        public string NetworkName {
            get { return BackingStore?.Get<string>("networkName"); }
            set { BackingStore?.Set("networkName", value); }
        }
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public string PreSharedKey {
            get { return BackingStore?.Get<string>("preSharedKey"); }
            set { BackingStore?.Set("preSharedKey", value); }
        }
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public bool? PreSharedKeyIsSet {
            get { return BackingStore?.Get<bool?>("preSharedKeyIsSet"); }
            set { BackingStore?.Set("preSharedKeyIsSet", value); }
        }
        /// <summary>Specify the proxy server configuration script URL.</summary>
        public string ProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string>("proxyAutomaticConfigurationUrl"); }
            set { BackingStore?.Set("proxyAutomaticConfigurationUrl", value); }
        }
        /// <summary>List of hosts to exclude using the proxy on connections for. These hosts can use wildcards such as .example.com.</summary>
        public string ProxyExclusionList {
            get { return BackingStore?.Get<string>("proxyExclusionList"); }
            set { BackingStore?.Set("proxyExclusionList", value); }
        }
        /// <summary>Specify the proxy server IP address. Android documentation does not specify IPv4 or IPv6. For example: 192.168.1.1.</summary>
        public string ProxyManualAddress {
            get { return BackingStore?.Get<string>("proxyManualAddress"); }
            set { BackingStore?.Set("proxyManualAddress", value); }
        }
        /// <summary>Specify the proxy server port.</summary>
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
        /// <summary>Wi-Fi Security Types for Android Device Owner.</summary>
        public AndroidDeviceOwnerWiFiSecurityType? WiFiSecurityType {
            get { return BackingStore?.Get<AndroidDeviceOwnerWiFiSecurityType?>("wiFiSecurityType"); }
            set { BackingStore?.Set("wiFiSecurityType", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidDeviceOwnerWiFiConfiguration and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerWiFiConfiguration() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerWiFiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidDeviceOwnerEnterpriseWiFiConfiguration" => new AndroidDeviceOwnerEnterpriseWiFiConfiguration(),
                _ => new AndroidDeviceOwnerWiFiConfiguration(),
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
                {"proxyAutomaticConfigurationUrl", n => { ProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                {"proxyExclusionList", n => { ProxyExclusionList = n.GetStringValue(); } },
                {"proxyManualAddress", n => { ProxyManualAddress = n.GetStringValue(); } },
                {"proxyManualPort", n => { ProxyManualPort = n.GetIntValue(); } },
                {"proxySettings", n => { ProxySettings = n.GetEnumValue<WiFiProxySetting>(); } },
                {"ssid", n => { Ssid = n.GetStringValue(); } },
                {"wiFiSecurityType", n => { WiFiSecurityType = n.GetEnumValue<AndroidDeviceOwnerWiFiSecurityType>(); } },
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
            writer.WriteStringValue("proxyAutomaticConfigurationUrl", ProxyAutomaticConfigurationUrl);
            writer.WriteStringValue("proxyExclusionList", ProxyExclusionList);
            writer.WriteStringValue("proxyManualAddress", ProxyManualAddress);
            writer.WriteIntValue("proxyManualPort", ProxyManualPort);
            writer.WriteEnumValue<WiFiProxySetting>("proxySettings", ProxySettings);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<AndroidDeviceOwnerWiFiSecurityType>("wiFiSecurityType", WiFiSecurityType);
        }
    }
}
