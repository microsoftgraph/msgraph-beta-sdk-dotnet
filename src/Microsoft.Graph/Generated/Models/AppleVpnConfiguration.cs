using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppleVpnConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Associated Domains</summary>
        public List<string> AssociatedDomains {
            get { return BackingStore?.Get<List<string>>("associatedDomains"); }
            set { BackingStore?.Set("associatedDomains", value); }
        }
        /// <summary>VPN Authentication Method.</summary>
        public VpnAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<VpnAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Connection name displayed to the user.</summary>
        public string ConnectionName {
            get { return BackingStore?.Get<string>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
        /// <summary>Apple VPN connection type.</summary>
        public AppleVpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<AppleVpnConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>Custom data when connection type is set to Custom VPN. Use this field to enable functionality not supported by Intune, but available in your VPN solution. Contact your VPN vendor to learn how to add these key/value pairs. This collection can contain a maximum of 25 elements.</summary>
        public List<KeyValue> CustomData {
            get { return BackingStore?.Get<List<KeyValue>>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
        /// <summary>Custom data when connection type is set to Custom VPN. Use this field to enable functionality not supported by Intune, but available in your VPN solution. Contact your VPN vendor to learn how to add these key/value pairs. This collection can contain a maximum of 25 elements.</summary>
        public List<KeyValuePair> CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
        /// <summary>Toggle to prevent user from disabling automatic VPN in the Settings app</summary>
        public bool? DisableOnDemandUserOverride {
            get { return BackingStore?.Get<bool?>("disableOnDemandUserOverride"); }
            set { BackingStore?.Set("disableOnDemandUserOverride", value); }
        }
        /// <summary>Whether to disconnect after on-demand connection idles</summary>
        public bool? DisconnectOnIdle {
            get { return BackingStore?.Get<bool?>("disconnectOnIdle"); }
            set { BackingStore?.Set("disconnectOnIdle", value); }
        }
        /// <summary>The length of time in seconds to wait before disconnecting an on-demand connection. Valid values 0 to 65535</summary>
        public int? DisconnectOnIdleTimerInSeconds {
            get { return BackingStore?.Get<int?>("disconnectOnIdleTimerInSeconds"); }
            set { BackingStore?.Set("disconnectOnIdleTimerInSeconds", value); }
        }
        /// <summary>Setting this to true creates Per-App VPN payload which can later be associated with Apps that can trigger this VPN conneciton on the end user&apos;s iOS device.</summary>
        public bool? EnablePerApp {
            get { return BackingStore?.Get<bool?>("enablePerApp"); }
            set { BackingStore?.Set("enablePerApp", value); }
        }
        /// <summary>Send all network traffic through VPN.</summary>
        public bool? EnableSplitTunneling {
            get { return BackingStore?.Get<bool?>("enableSplitTunneling"); }
            set { BackingStore?.Set("enableSplitTunneling", value); }
        }
        /// <summary>Domains that are accessed through the public internet instead of through VPN, even when per-app VPN is activated</summary>
        public List<string> ExcludedDomains {
            get { return BackingStore?.Get<List<string>>("excludedDomains"); }
            set { BackingStore?.Set("excludedDomains", value); }
        }
        /// <summary>Identifier provided by VPN vendor when connection type is set to Custom VPN. For example: Cisco AnyConnect uses an identifier of the form com.cisco.anyconnect.applevpn.plugin</summary>
        public string Identifier {
            get { return BackingStore?.Get<string>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>Login group or domain when connection type is set to Dell SonicWALL Mobile Connection.</summary>
        public string LoginGroupOrDomain {
            get { return BackingStore?.Get<string>("loginGroupOrDomain"); }
            set { BackingStore?.Set("loginGroupOrDomain", value); }
        }
        /// <summary>On-Demand Rules. This collection can contain a maximum of 500 elements.</summary>
        public List<VpnOnDemandRule> OnDemandRules {
            get { return BackingStore?.Get<List<VpnOnDemandRule>>("onDemandRules"); }
            set { BackingStore?.Set("onDemandRules", value); }
        }
        /// <summary>Opt-In to sharing the device&apos;s Id to third-party vpn clients for use during network access control validation.</summary>
        public bool? OptInToDeviceIdSharing {
            get { return BackingStore?.Get<bool?>("optInToDeviceIdSharing"); }
            set { BackingStore?.Set("optInToDeviceIdSharing", value); }
        }
        /// <summary>Provider type for per-app VPN. Possible values are: notConfigured, appProxy, packetTunnel.</summary>
        public VpnProviderType? ProviderType {
            get { return BackingStore?.Get<VpnProviderType?>("providerType"); }
            set { BackingStore?.Set("providerType", value); }
        }
        /// <summary>Proxy Server.</summary>
        public VpnProxyServer ProxyServer {
            get { return BackingStore?.Get<VpnProxyServer>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
        /// <summary>Realm when connection type is set to Pulse Secure.</summary>
        public string Realm {
            get { return BackingStore?.Get<string>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
        /// <summary>Role when connection type is set to Pulse Secure.</summary>
        public string Role {
            get { return BackingStore?.Get<string>("role"); }
            set { BackingStore?.Set("role", value); }
        }
        /// <summary>Safari domains when this VPN per App setting is enabled. In addition to the apps associated with this VPN, Safari domains specified here will also be able to trigger this VPN connection.</summary>
        public List<string> SafariDomains {
            get { return BackingStore?.Get<List<string>>("safariDomains"); }
            set { BackingStore?.Set("safariDomains", value); }
        }
        /// <summary>VPN Server definition.</summary>
        public VpnServer Server {
            get { return BackingStore?.Get<VpnServer>("server"); }
            set { BackingStore?.Set("server", value); }
        }
        /// <summary>
        /// Instantiates a new AppleVpnConfiguration and sets the default values.
        /// </summary>
        public AppleVpnConfiguration() : base() {
            OdataType = "#microsoft.graph.appleVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AppleVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosikEv2VpnConfiguration" => new IosikEv2VpnConfiguration(),
                "#microsoft.graph.iosVpnConfiguration" => new IosVpnConfiguration(),
                "#microsoft.graph.macOSVpnConfiguration" => new MacOSVpnConfiguration(),
                _ => new AppleVpnConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associatedDomains", n => { AssociatedDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<VpnAuthenticationMethod>(); } },
                {"connectionName", n => { ConnectionName = n.GetStringValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<AppleVpnConnectionType>(); } },
                {"customData", n => { CustomData = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"customKeyValueData", n => { CustomKeyValueData = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"disableOnDemandUserOverride", n => { DisableOnDemandUserOverride = n.GetBoolValue(); } },
                {"disconnectOnIdle", n => { DisconnectOnIdle = n.GetBoolValue(); } },
                {"disconnectOnIdleTimerInSeconds", n => { DisconnectOnIdleTimerInSeconds = n.GetIntValue(); } },
                {"enablePerApp", n => { EnablePerApp = n.GetBoolValue(); } },
                {"enableSplitTunneling", n => { EnableSplitTunneling = n.GetBoolValue(); } },
                {"excludedDomains", n => { ExcludedDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"loginGroupOrDomain", n => { LoginGroupOrDomain = n.GetStringValue(); } },
                {"onDemandRules", n => { OnDemandRules = n.GetCollectionOfObjectValues<VpnOnDemandRule>(VpnOnDemandRule.CreateFromDiscriminatorValue).ToList(); } },
                {"optInToDeviceIdSharing", n => { OptInToDeviceIdSharing = n.GetBoolValue(); } },
                {"providerType", n => { ProviderType = n.GetEnumValue<VpnProviderType>(); } },
                {"proxyServer", n => { ProxyServer = n.GetObjectValue<VpnProxyServer>(VpnProxyServer.CreateFromDiscriminatorValue); } },
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"safariDomains", n => { SafariDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"server", n => { Server = n.GetObjectValue<VpnServer>(VpnServer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("associatedDomains", AssociatedDomains);
            writer.WriteEnumValue<VpnAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteStringValue("connectionName", ConnectionName);
            writer.WriteEnumValue<AppleVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteCollectionOfObjectValues<KeyValue>("customData", CustomData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customKeyValueData", CustomKeyValueData);
            writer.WriteBoolValue("disableOnDemandUserOverride", DisableOnDemandUserOverride);
            writer.WriteBoolValue("disconnectOnIdle", DisconnectOnIdle);
            writer.WriteIntValue("disconnectOnIdleTimerInSeconds", DisconnectOnIdleTimerInSeconds);
            writer.WriteBoolValue("enablePerApp", EnablePerApp);
            writer.WriteBoolValue("enableSplitTunneling", EnableSplitTunneling);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedDomains", ExcludedDomains);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteStringValue("loginGroupOrDomain", LoginGroupOrDomain);
            writer.WriteCollectionOfObjectValues<VpnOnDemandRule>("onDemandRules", OnDemandRules);
            writer.WriteBoolValue("optInToDeviceIdSharing", OptInToDeviceIdSharing);
            writer.WriteEnumValue<VpnProviderType>("providerType", ProviderType);
            writer.WriteObjectValue<VpnProxyServer>("proxyServer", ProxyServer);
            writer.WriteStringValue("realm", Realm);
            writer.WriteStringValue("role", Role);
            writer.WriteCollectionOfPrimitiveValues<string>("safariDomains", SafariDomains);
            writer.WriteObjectValue<VpnServer>("server", Server);
        }
    }
}
