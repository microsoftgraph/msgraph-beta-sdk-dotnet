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
            get { return BackingStore?.Get<bool?>("connectAutomatically"); }
            set { BackingStore?.Set("connectAutomatically", value); }
        }
        /// <summary>Specify whether the wifi connection should connect to more preferred networks when already connected to this one.  Requires ConnectAutomatically to be true.</summary>
        public bool? ConnectToPreferredNetwork {
            get { return BackingStore?.Get<bool?>("connectToPreferredNetwork"); }
            set { BackingStore?.Set("connectToPreferredNetwork", value); }
        }
        /// <summary>Specify whether the wifi connection should connect automatically even when the SSID is not broadcasting.</summary>
        public bool? ConnectWhenNetworkNameIsHidden {
            get { return BackingStore?.Get<bool?>("connectWhenNetworkNameIsHidden"); }
            set { BackingStore?.Set("connectWhenNetworkNameIsHidden", value); }
        }
        /// <summary>Specify whether to force FIPS compliance.</summary>
        public bool? ForceFIPSCompliance {
            get { return BackingStore?.Get<bool?>("forceFIPSCompliance"); }
            set { BackingStore?.Set("forceFIPSCompliance", value); }
        }
        /// <summary>Specify the metered connection limit type for the wifi connection. Possible values are: unrestricted, fixed, variable.</summary>
        public MeteredConnectionLimitType? MeteredConnectionLimit {
            get { return BackingStore?.Get<MeteredConnectionLimitType?>("meteredConnectionLimit"); }
            set { BackingStore?.Set("meteredConnectionLimit", value); }
        }
        /// <summary>Specify the network configuration name.</summary>
        public string NetworkName {
            get { return BackingStore?.Get<string>("networkName"); }
            set { BackingStore?.Set("networkName", value); }
        }
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public string PreSharedKey {
            get { return BackingStore?.Get<string>("preSharedKey"); }
            set { BackingStore?.Set("preSharedKey", value); }
        }
        /// <summary>Specify the URL for the proxy server configuration script.</summary>
        public string ProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string>("proxyAutomaticConfigurationUrl"); }
            set { BackingStore?.Set("proxyAutomaticConfigurationUrl", value); }
        }
        /// <summary>Specify the IP address for the proxy server.</summary>
        public string ProxyManualAddress {
            get { return BackingStore?.Get<string>("proxyManualAddress"); }
            set { BackingStore?.Set("proxyManualAddress", value); }
        }
        /// <summary>Specify the port for the proxy server.</summary>
        public int? ProxyManualPort {
            get { return BackingStore?.Get<int?>("proxyManualPort"); }
            set { BackingStore?.Set("proxyManualPort", value); }
        }
        /// <summary>Specify the proxy setting for Wi-Fi configuration. Possible values are: none, manual, automatic.</summary>
        public WiFiProxySetting? ProxySetting {
            get { return BackingStore?.Get<WiFiProxySetting?>("proxySetting"); }
            set { BackingStore?.Set("proxySetting", value); }
        }
        /// <summary>Specify the SSID of the wifi connection.</summary>
        public string Ssid {
            get { return BackingStore?.Get<string>("ssid"); }
            set { BackingStore?.Set("ssid", value); }
        }
        /// <summary>Specify the Wifi Security Type. Possible values are: open, wpaPersonal, wpaEnterprise, wep, wpa2Personal, wpa2Enterprise.</summary>
        public Microsoft.Graph.Beta.Models.WiFiSecurityType? WifiSecurityType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WiFiSecurityType?>("wifiSecurityType"); }
            set { BackingStore?.Set("wifiSecurityType", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsWifiConfiguration and sets the default values.
        /// </summary>
        public WindowsWifiConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsWifiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsWifiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
