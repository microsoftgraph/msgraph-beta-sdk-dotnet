using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsWifiConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Specify whether the wifi connection should connect automatically when in range.</summary>
        public bool? ConnectAutomatically {
            get { return BackingStore?.Get<bool?>(nameof(ConnectAutomatically)); }
            set { BackingStore?.Set(nameof(ConnectAutomatically), value); }
        }
        /// <summary>Specify whether the wifi connection should connect to more preferred networks when already connected to this one.  Requires ConnectAutomatically to be true.</summary>
        public bool? ConnectToPreferredNetwork {
            get { return BackingStore?.Get<bool?>(nameof(ConnectToPreferredNetwork)); }
            set { BackingStore?.Set(nameof(ConnectToPreferredNetwork), value); }
        }
        /// <summary>Specify whether the wifi connection should connect automatically even when the SSID is not broadcasting.</summary>
        public bool? ConnectWhenNetworkNameIsHidden {
            get { return BackingStore?.Get<bool?>(nameof(ConnectWhenNetworkNameIsHidden)); }
            set { BackingStore?.Set(nameof(ConnectWhenNetworkNameIsHidden), value); }
        }
        /// <summary>Specify whether to force FIPS compliance.</summary>
        public bool? ForceFIPSCompliance {
            get { return BackingStore?.Get<bool?>(nameof(ForceFIPSCompliance)); }
            set { BackingStore?.Set(nameof(ForceFIPSCompliance), value); }
        }
        /// <summary>Specify the metered connection limit type for the wifi connection. Possible values are: unrestricted, fixed, variable.</summary>
        public MeteredConnectionLimitType? MeteredConnectionLimit {
            get { return BackingStore?.Get<MeteredConnectionLimitType?>(nameof(MeteredConnectionLimit)); }
            set { BackingStore?.Set(nameof(MeteredConnectionLimit), value); }
        }
        /// <summary>Specify the network configuration name.</summary>
        public string NetworkName {
            get { return BackingStore?.Get<string>(nameof(NetworkName)); }
            set { BackingStore?.Set(nameof(NetworkName), value); }
        }
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public string PreSharedKey {
            get { return BackingStore?.Get<string>(nameof(PreSharedKey)); }
            set { BackingStore?.Set(nameof(PreSharedKey), value); }
        }
        /// <summary>Specify the URL for the proxy server configuration script.</summary>
        public string ProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string>(nameof(ProxyAutomaticConfigurationUrl)); }
            set { BackingStore?.Set(nameof(ProxyAutomaticConfigurationUrl), value); }
        }
        /// <summary>Specify the IP address for the proxy server.</summary>
        public string ProxyManualAddress {
            get { return BackingStore?.Get<string>(nameof(ProxyManualAddress)); }
            set { BackingStore?.Set(nameof(ProxyManualAddress), value); }
        }
        /// <summary>Specify the port for the proxy server.</summary>
        public int? ProxyManualPort {
            get { return BackingStore?.Get<int?>(nameof(ProxyManualPort)); }
            set { BackingStore?.Set(nameof(ProxyManualPort), value); }
        }
        /// <summary>Specify the proxy setting for Wi-Fi configuration. Possible values are: none, manual, automatic.</summary>
        public WiFiProxySetting? ProxySetting {
            get { return BackingStore?.Get<WiFiProxySetting?>(nameof(ProxySetting)); }
            set { BackingStore?.Set(nameof(ProxySetting), value); }
        }
        /// <summary>Specify the SSID of the wifi connection.</summary>
        public string Ssid {
            get { return BackingStore?.Get<string>(nameof(Ssid)); }
            set { BackingStore?.Set(nameof(Ssid), value); }
        }
        /// <summary>Specify the Wifi Security Type. Possible values are: open, wpaPersonal, wpaEnterprise, wep, wpa2Personal, wpa2Enterprise.</summary>
        public Microsoft.Graph.Beta.Models.WiFiSecurityType? WifiSecurityType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WiFiSecurityType?>(nameof(WifiSecurityType)); }
            set { BackingStore?.Set(nameof(WifiSecurityType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsWifiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsWifiEnterpriseEAPConfiguration" => new WindowsWifiEnterpriseEAPConfiguration(),
                _ => new WindowsWifiConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectAutomatically", n => { ConnectAutomatically = n.GetBoolValue(); } },
                {"connectToPreferredNetwork", n => { ConnectToPreferredNetwork = n.GetBoolValue(); } },
                {"connectWhenNetworkNameIsHidden", n => { ConnectWhenNetworkNameIsHidden = n.GetBoolValue(); } },
                {"forceFIPSCompliance", n => { ForceFIPSCompliance = n.GetBoolValue(); } },
                {"meteredConnectionLimit", n => { MeteredConnectionLimit = n.GetEnumValue<MeteredConnectionLimitType>(); } },
                {"networkName", n => { NetworkName = n.GetStringValue(); } },
                {"preSharedKey", n => { PreSharedKey = n.GetStringValue(); } },
                {"proxyAutomaticConfigurationUrl", n => { ProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                {"proxyManualAddress", n => { ProxyManualAddress = n.GetStringValue(); } },
                {"proxyManualPort", n => { ProxyManualPort = n.GetIntValue(); } },
                {"proxySetting", n => { ProxySetting = n.GetEnumValue<WiFiProxySetting>(); } },
                {"ssid", n => { Ssid = n.GetStringValue(); } },
                {"wifiSecurityType", n => { WifiSecurityType = n.GetEnumValue<WiFiSecurityType>(); } },
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
            writer.WriteBoolValue("connectToPreferredNetwork", ConnectToPreferredNetwork);
            writer.WriteBoolValue("connectWhenNetworkNameIsHidden", ConnectWhenNetworkNameIsHidden);
            writer.WriteBoolValue("forceFIPSCompliance", ForceFIPSCompliance);
            writer.WriteEnumValue<MeteredConnectionLimitType>("meteredConnectionLimit", MeteredConnectionLimit);
            writer.WriteStringValue("networkName", NetworkName);
            writer.WriteStringValue("preSharedKey", PreSharedKey);
            writer.WriteStringValue("proxyAutomaticConfigurationUrl", ProxyAutomaticConfigurationUrl);
            writer.WriteStringValue("proxyManualAddress", ProxyManualAddress);
            writer.WriteIntValue("proxyManualPort", ProxyManualPort);
            writer.WriteEnumValue<WiFiProxySetting>("proxySetting", ProxySetting);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<WiFiSecurityType>("wifiSecurityType", WifiSecurityType);
        }
    }
}
