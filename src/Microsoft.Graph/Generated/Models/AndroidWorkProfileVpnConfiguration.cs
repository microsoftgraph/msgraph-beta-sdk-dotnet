using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// By providing the configurations in this profile you can instruct the Android Work Profile device to connect to desired VPN endpoint. By specifying the authentication method and security types expected by VPN endpoint you can make the VPN connection seamless for end user.
    /// </summary>
    public class AndroidWorkProfileVpnConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Whether or not to enable always-on VPN connection.</summary>
        public bool? AlwaysOn {
            get { return BackingStore?.Get<bool?>("alwaysOn"); }
            set { BackingStore?.Set("alwaysOn", value); }
        }
        /// <summary>If always-on VPN connection is enabled, whether or not to lock network traffic when that VPN is disconnected.</summary>
        public bool? AlwaysOnLockdown {
            get { return BackingStore?.Get<bool?>("alwaysOnLockdown"); }
            set { BackingStore?.Set("alwaysOnLockdown", value); }
        }
        /// <summary>VPN Authentication Method.</summary>
        public VpnAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<VpnAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Connection name displayed to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionName {
            get { return BackingStore?.Get<string?>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
#nullable restore
#else
        public string ConnectionName {
            get { return BackingStore?.Get<string>("connectionName"); }
            set { BackingStore?.Set("connectionName", value); }
        }
#endif
        /// <summary>Android Work Profile VPN connection type.</summary>
        public AndroidWorkProfileVpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<AndroidWorkProfileVpnConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? CustomData {
            get { return BackingStore?.Get<List<KeyValue>?>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#nullable restore
#else
        public List<KeyValue> CustomData {
            get { return BackingStore?.Get<List<KeyValue>>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#endif
        /// <summary>Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>?>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>>("customKeyValueData"); }
            set { BackingStore?.Set("customKeyValueData", value); }
        }
#endif
        /// <summary>Fingerprint is a string that will be used to verify the VPN server can be trusted, which is only applicable when connection type is Check Point Capsule VPN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fingerprint {
            get { return BackingStore?.Get<string?>("fingerprint"); }
            set { BackingStore?.Set("fingerprint", value); }
        }
#nullable restore
#else
        public string Fingerprint {
            get { return BackingStore?.Get<string>("fingerprint"); }
            set { BackingStore?.Set("fingerprint", value); }
        }
#endif
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidWorkProfileCertificateProfileBase? IdentityCertificate {
            get { return BackingStore?.Get<AndroidWorkProfileCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public AndroidWorkProfileCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidWorkProfileCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Microsoft Tunnel site ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string?>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
#nullable restore
#else
        public string MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
#endif
        /// <summary>Proxy server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VpnProxyServer? ProxyServer {
            get { return BackingStore?.Get<VpnProxyServer?>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
#nullable restore
#else
        public VpnProxyServer ProxyServer {
            get { return BackingStore?.Get<VpnProxyServer>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
#endif
        /// <summary>Realm when connection type is set to Pulse Secure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Realm {
            get { return BackingStore?.Get<string?>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
#nullable restore
#else
        public string Realm {
            get { return BackingStore?.Get<string>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
#endif
        /// <summary>Role when connection type is set to Pulse Secure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role {
            get { return BackingStore?.Get<string?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#nullable restore
#else
        public string Role {
            get { return BackingStore?.Get<string>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#endif
        /// <summary>List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VpnServer>? Servers {
            get { return BackingStore?.Get<List<VpnServer>?>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#nullable restore
#else
        public List<VpnServer> Servers {
            get { return BackingStore?.Get<List<VpnServer>>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#endif
        /// <summary>Targeted mobile apps. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppListItem>? TargetedMobileApps {
            get { return BackingStore?.Get<List<AppListItem>?>("targetedMobileApps"); }
            set { BackingStore?.Set("targetedMobileApps", value); }
        }
#nullable restore
#else
        public List<AppListItem> TargetedMobileApps {
            get { return BackingStore?.Get<List<AppListItem>>("targetedMobileApps"); }
            set { BackingStore?.Set("targetedMobileApps", value); }
        }
#endif
        /// <summary>Targeted App package IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TargetedPackageIds {
            get { return BackingStore?.Get<List<string>?>("targetedPackageIds"); }
            set { BackingStore?.Set("targetedPackageIds", value); }
        }
#nullable restore
#else
        public List<string> TargetedPackageIds {
            get { return BackingStore?.Get<List<string>>("targetedPackageIds"); }
            set { BackingStore?.Set("targetedPackageIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new androidWorkProfileVpnConfiguration and sets the default values.
        /// </summary>
        public AndroidWorkProfileVpnConfiguration() : base() {
            OdataType = "#microsoft.graph.androidWorkProfileVpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidWorkProfileVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidWorkProfileVpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alwaysOn", n => { AlwaysOn = n.GetBoolValue(); } },
                {"alwaysOnLockdown", n => { AlwaysOnLockdown = n.GetBoolValue(); } },
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<VpnAuthenticationMethod>(); } },
                {"connectionName", n => { ConnectionName = n.GetStringValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<AndroidWorkProfileVpnConnectionType>(); } },
                {"customData", n => { CustomData = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customKeyValueData", n => { CustomKeyValueData = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidWorkProfileCertificateProfileBase>(AndroidWorkProfileCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelSiteId", n => { MicrosoftTunnelSiteId = n.GetStringValue(); } },
                {"proxyServer", n => { ProxyServer = n.GetObjectValue<VpnProxyServer>(VpnProxyServer.CreateFromDiscriminatorValue); } },
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"servers", n => { Servers = n.GetCollectionOfObjectValues<VpnServer>(VpnServer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"targetedMobileApps", n => { TargetedMobileApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"targetedPackageIds", n => { TargetedPackageIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("alwaysOn", AlwaysOn);
            writer.WriteBoolValue("alwaysOnLockdown", AlwaysOnLockdown);
            writer.WriteEnumValue<VpnAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteStringValue("connectionName", ConnectionName);
            writer.WriteEnumValue<AndroidWorkProfileVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteCollectionOfObjectValues<KeyValue>("customData", CustomData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customKeyValueData", CustomKeyValueData);
            writer.WriteStringValue("fingerprint", Fingerprint);
            writer.WriteObjectValue<AndroidWorkProfileCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("microsoftTunnelSiteId", MicrosoftTunnelSiteId);
            writer.WriteObjectValue<VpnProxyServer>("proxyServer", ProxyServer);
            writer.WriteStringValue("realm", Realm);
            writer.WriteStringValue("role", Role);
            writer.WriteCollectionOfObjectValues<VpnServer>("servers", Servers);
            writer.WriteCollectionOfObjectValues<AppListItem>("targetedMobileApps", TargetedMobileApps);
            writer.WriteCollectionOfPrimitiveValues<string>("targetedPackageIds", TargetedPackageIds);
        }
    }
}
