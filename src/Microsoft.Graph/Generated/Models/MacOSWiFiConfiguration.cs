using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSWiFiConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.</summary>
        public bool? ConnectAutomatically {
            get { return BackingStore?.Get<bool?>(nameof(ConnectAutomatically)); }
            set { BackingStore?.Set(nameof(ConnectAutomatically), value); }
        }
        /// <summary>Connect when the network is not broadcasting its name (SSID). When set to true, this profile forces the device to connect to a network that doesn&apos;t broadcast its SSID to all devices.</summary>
        public bool? ConnectWhenNetworkNameIsHidden {
            get { return BackingStore?.Get<bool?>(nameof(ConnectWhenNetworkNameIsHidden)); }
            set { BackingStore?.Set(nameof(ConnectWhenNetworkNameIsHidden), value); }
        }
        /// <summary>Network Name</summary>
        public string NetworkName {
            get { return BackingStore?.Get<string>(nameof(NetworkName)); }
            set { BackingStore?.Set(nameof(NetworkName), value); }
        }
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public string PreSharedKey {
            get { return BackingStore?.Get<string>(nameof(PreSharedKey)); }
            set { BackingStore?.Set(nameof(PreSharedKey), value); }
        }
        /// <summary>URL of the proxy server automatic configuration script when automatic configuration is selected. This URL is typically the location of PAC (Proxy Auto Configuration) file.</summary>
        public string ProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string>(nameof(ProxyAutomaticConfigurationUrl)); }
            set { BackingStore?.Set(nameof(ProxyAutomaticConfigurationUrl), value); }
        }
        /// <summary>IP Address or DNS hostname of the proxy server when manual configuration is selected.</summary>
        public string ProxyManualAddress {
            get { return BackingStore?.Get<string>(nameof(ProxyManualAddress)); }
            set { BackingStore?.Set(nameof(ProxyManualAddress), value); }
        }
        /// <summary>Port of the proxy server when manual configuration is selected.</summary>
        public int? ProxyManualPort {
            get { return BackingStore?.Get<int?>(nameof(ProxyManualPort)); }
            set { BackingStore?.Set(nameof(ProxyManualPort), value); }
        }
        /// <summary>Proxy Type for this Wi-Fi connection. Possible values are: none, manual, automatic.</summary>
        public WiFiProxySetting? ProxySettings {
            get { return BackingStore?.Get<WiFiProxySetting?>(nameof(ProxySettings)); }
            set { BackingStore?.Set(nameof(ProxySettings), value); }
        }
        /// <summary>This is the name of the Wi-Fi network that is broadcast to all devices.</summary>
        public string Ssid {
            get { return BackingStore?.Get<string>(nameof(Ssid)); }
            set { BackingStore?.Set(nameof(Ssid), value); }
        }
        /// <summary>Indicates whether Wi-Fi endpoint uses an EAP based security type. Possible values are: open, wpaPersonal, wpaEnterprise, wep, wpa2Personal, wpa2Enterprise.</summary>
        public Microsoft.Graph.Beta.Models.WiFiSecurityType? WiFiSecurityType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WiFiSecurityType?>(nameof(WiFiSecurityType)); }
            set { BackingStore?.Set(nameof(WiFiSecurityType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSWiFiConfiguration();
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("connectAutomatically", ConnectAutomatically);
            writer.WriteBoolValue("connectWhenNetworkNameIsHidden", ConnectWhenNetworkNameIsHidden);
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
