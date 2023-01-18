using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10VpnConfiguration : WindowsVpnConfiguration, IParsable {
        /// <summary>Associated Apps. This collection can contain a maximum of 10000 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Windows10AssociatedApps>? AssociatedApps {
            get { return BackingStore?.Get<List<Windows10AssociatedApps>?>("associatedApps"); }
            set { BackingStore?.Set("associatedApps", value); }
        }
#else
        public List<Windows10AssociatedApps> AssociatedApps {
            get { return BackingStore?.Get<List<Windows10AssociatedApps>>("associatedApps"); }
            set { BackingStore?.Set("associatedApps", value); }
        }
#endif
        /// <summary>Windows 10 VPN connection types.</summary>
        public Windows10VpnAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<Windows10VpnAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>VPN connection types.</summary>
        public Windows10VpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<Windows10VpnConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>Cryptography Suite security settings for IKEv2 VPN in Windows10 and above</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.CryptographySuite? CryptographySuite {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CryptographySuite?>("cryptographySuite"); }
            set { BackingStore?.Set("cryptographySuite", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.CryptographySuite CryptographySuite {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CryptographySuite>("cryptographySuite"); }
            set { BackingStore?.Set("cryptographySuite", value); }
        }
#endif
        /// <summary>DNS rules. This collection can contain a maximum of 1000 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<VpnDnsRule>? DnsRules {
            get { return BackingStore?.Get<List<VpnDnsRule>?>("dnsRules"); }
            set { BackingStore?.Set("dnsRules", value); }
        }
#else
        public List<VpnDnsRule> DnsRules {
            get { return BackingStore?.Get<List<VpnDnsRule>>("dnsRules"); }
            set { BackingStore?.Set("dnsRules", value); }
        }
#endif
        /// <summary>Specify DNS suffixes to add to the DNS search list to properly route short names.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? DnsSuffixes {
            get { return BackingStore?.Get<List<string>?>("dnsSuffixes"); }
            set { BackingStore?.Set("dnsSuffixes", value); }
        }
#else
        public List<string> DnsSuffixes {
            get { return BackingStore?.Get<List<string>>("dnsSuffixes"); }
            set { BackingStore?.Set("dnsSuffixes", value); }
        }
#endif
        /// <summary>Extensible Authentication Protocol (EAP) XML. (UTF8 encoded byte array)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public byte[]? EapXml {
            get { return BackingStore?.Get<byte[]?>("eapXml"); }
            set { BackingStore?.Set("eapXml", value); }
        }
#else
        public byte[] EapXml {
            get { return BackingStore?.Get<byte[]>("eapXml"); }
            set { BackingStore?.Set("eapXml", value); }
        }
#endif
        /// <summary>Enable Always On mode.</summary>
        public bool? EnableAlwaysOn {
            get { return BackingStore?.Get<bool?>("enableAlwaysOn"); }
            set { BackingStore?.Set("enableAlwaysOn", value); }
        }
        /// <summary>Enable conditional access.</summary>
        public bool? EnableConditionalAccess {
            get { return BackingStore?.Get<bool?>("enableConditionalAccess"); }
            set { BackingStore?.Set("enableConditionalAccess", value); }
        }
        /// <summary>Enable device tunnel.</summary>
        public bool? EnableDeviceTunnel {
            get { return BackingStore?.Get<bool?>("enableDeviceTunnel"); }
            set { BackingStore?.Set("enableDeviceTunnel", value); }
        }
        /// <summary>Enable IP address registration with internal DNS.</summary>
        public bool? EnableDnsRegistration {
            get { return BackingStore?.Get<bool?>("enableDnsRegistration"); }
            set { BackingStore?.Set("enableDnsRegistration", value); }
        }
        /// <summary>Enable single sign-on (SSO) with alternate certificate.</summary>
        public bool? EnableSingleSignOnWithAlternateCertificate {
            get { return BackingStore?.Get<bool?>("enableSingleSignOnWithAlternateCertificate"); }
            set { BackingStore?.Set("enableSingleSignOnWithAlternateCertificate", value); }
        }
        /// <summary>Enable split tunneling.</summary>
        public bool? EnableSplitTunneling {
            get { return BackingStore?.Get<bool?>("enableSplitTunneling"); }
            set { BackingStore?.Set("enableSplitTunneling", value); }
        }
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public WindowsCertificateProfileBase? IdentityCertificate {
            get { return BackingStore?.Get<WindowsCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#else
        public WindowsCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<WindowsCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>ID of the Microsoft Tunnel site associated with the VPN profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string?>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
#else
        public string MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string>("microsoftTunnelSiteId"); }
            set { BackingStore?.Set("microsoftTunnelSiteId", value); }
        }
#endif
        /// <summary>Only associated Apps can use connection (per-app VPN).</summary>
        public bool? OnlyAssociatedAppsCanUseConnection {
            get { return BackingStore?.Get<bool?>("onlyAssociatedAppsCanUseConnection"); }
            set { BackingStore?.Set("onlyAssociatedAppsCanUseConnection", value); }
        }
        /// <summary>Profile target type. Possible values are: user, device, autoPilotDevice.</summary>
        public Windows10VpnProfileTarget? ProfileTarget {
            get { return BackingStore?.Get<Windows10VpnProfileTarget?>("profileTarget"); }
            set { BackingStore?.Set("profileTarget", value); }
        }
        /// <summary>Proxy Server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Windows10VpnProxyServer? ProxyServer {
            get { return BackingStore?.Get<Windows10VpnProxyServer?>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
#else
        public Windows10VpnProxyServer ProxyServer {
            get { return BackingStore?.Get<Windows10VpnProxyServer>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
#endif
        /// <summary>Remember user credentials.</summary>
        public bool? RememberUserCredentials {
            get { return BackingStore?.Get<bool?>("rememberUserCredentials"); }
            set { BackingStore?.Set("rememberUserCredentials", value); }
        }
        /// <summary>Routes (optional for third-party providers). This collection can contain a maximum of 1000 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<VpnRoute>? Routes {
            get { return BackingStore?.Get<List<VpnRoute>?>("routes"); }
            set { BackingStore?.Set("routes", value); }
        }
#else
        public List<VpnRoute> Routes {
            get { return BackingStore?.Get<List<VpnRoute>>("routes"); }
            set { BackingStore?.Set("routes", value); }
        }
#endif
        /// <summary>Single sign-on Extended Key Usage (EKU).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public ExtendedKeyUsage? SingleSignOnEku {
            get { return BackingStore?.Get<ExtendedKeyUsage?>("singleSignOnEku"); }
            set { BackingStore?.Set("singleSignOnEku", value); }
        }
#else
        public ExtendedKeyUsage SingleSignOnEku {
            get { return BackingStore?.Get<ExtendedKeyUsage>("singleSignOnEku"); }
            set { BackingStore?.Set("singleSignOnEku", value); }
        }
#endif
        /// <summary>Single sign-on issuer hash.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SingleSignOnIssuerHash {
            get { return BackingStore?.Get<string?>("singleSignOnIssuerHash"); }
            set { BackingStore?.Set("singleSignOnIssuerHash", value); }
        }
#else
        public string SingleSignOnIssuerHash {
            get { return BackingStore?.Get<string>("singleSignOnIssuerHash"); }
            set { BackingStore?.Set("singleSignOnIssuerHash", value); }
        }
#endif
        /// <summary>Traffic rules. This collection can contain a maximum of 1000 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<VpnTrafficRule>? TrafficRules {
            get { return BackingStore?.Get<List<VpnTrafficRule>?>("trafficRules"); }
            set { BackingStore?.Set("trafficRules", value); }
        }
#else
        public List<VpnTrafficRule> TrafficRules {
            get { return BackingStore?.Get<List<VpnTrafficRule>>("trafficRules"); }
            set { BackingStore?.Set("trafficRules", value); }
        }
#endif
        /// <summary>Trusted Network Domains</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? TrustedNetworkDomains {
            get { return BackingStore?.Get<List<string>?>("trustedNetworkDomains"); }
            set { BackingStore?.Set("trustedNetworkDomains", value); }
        }
#else
        public List<string> TrustedNetworkDomains {
            get { return BackingStore?.Get<List<string>>("trustedNetworkDomains"); }
            set { BackingStore?.Set("trustedNetworkDomains", value); }
        }
#endif
        /// <summary>Windows Information Protection (WIP) domain to associate with this connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? WindowsInformationProtectionDomain {
            get { return BackingStore?.Get<string?>("windowsInformationProtectionDomain"); }
            set { BackingStore?.Set("windowsInformationProtectionDomain", value); }
        }
#else
        public string WindowsInformationProtectionDomain {
            get { return BackingStore?.Get<string>("windowsInformationProtectionDomain"); }
            set { BackingStore?.Set("windowsInformationProtectionDomain", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Windows10VpnConfiguration and sets the default values.
        /// </summary>
        public Windows10VpnConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10VpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10VpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10VpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associatedApps", n => { AssociatedApps = n.GetCollectionOfObjectValues<Windows10AssociatedApps>(Windows10AssociatedApps.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<Windows10VpnAuthenticationMethod>(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<Windows10VpnConnectionType>(); } },
                {"cryptographySuite", n => { CryptographySuite = n.GetObjectValue<Microsoft.Graph.Beta.Models.CryptographySuite>(Microsoft.Graph.Beta.Models.CryptographySuite.CreateFromDiscriminatorValue); } },
                {"dnsRules", n => { DnsRules = n.GetCollectionOfObjectValues<VpnDnsRule>(VpnDnsRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dnsSuffixes", n => { DnsSuffixes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"eapXml", n => { EapXml = n.GetByteArrayValue(); } },
                {"enableAlwaysOn", n => { EnableAlwaysOn = n.GetBoolValue(); } },
                {"enableConditionalAccess", n => { EnableConditionalAccess = n.GetBoolValue(); } },
                {"enableDeviceTunnel", n => { EnableDeviceTunnel = n.GetBoolValue(); } },
                {"enableDnsRegistration", n => { EnableDnsRegistration = n.GetBoolValue(); } },
                {"enableSingleSignOnWithAlternateCertificate", n => { EnableSingleSignOnWithAlternateCertificate = n.GetBoolValue(); } },
                {"enableSplitTunneling", n => { EnableSplitTunneling = n.GetBoolValue(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<WindowsCertificateProfileBase>(WindowsCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"microsoftTunnelSiteId", n => { MicrosoftTunnelSiteId = n.GetStringValue(); } },
                {"onlyAssociatedAppsCanUseConnection", n => { OnlyAssociatedAppsCanUseConnection = n.GetBoolValue(); } },
                {"profileTarget", n => { ProfileTarget = n.GetEnumValue<Windows10VpnProfileTarget>(); } },
                {"proxyServer", n => { ProxyServer = n.GetObjectValue<Windows10VpnProxyServer>(Windows10VpnProxyServer.CreateFromDiscriminatorValue); } },
                {"rememberUserCredentials", n => { RememberUserCredentials = n.GetBoolValue(); } },
                {"routes", n => { Routes = n.GetCollectionOfObjectValues<VpnRoute>(VpnRoute.CreateFromDiscriminatorValue)?.ToList(); } },
                {"singleSignOnEku", n => { SingleSignOnEku = n.GetObjectValue<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue); } },
                {"singleSignOnIssuerHash", n => { SingleSignOnIssuerHash = n.GetStringValue(); } },
                {"trafficRules", n => { TrafficRules = n.GetCollectionOfObjectValues<VpnTrafficRule>(VpnTrafficRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trustedNetworkDomains", n => { TrustedNetworkDomains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"windowsInformationProtectionDomain", n => { WindowsInformationProtectionDomain = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Windows10AssociatedApps>("associatedApps", AssociatedApps);
            writer.WriteEnumValue<Windows10VpnAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteEnumValue<Windows10VpnConnectionType>("connectionType", ConnectionType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CryptographySuite>("cryptographySuite", CryptographySuite);
            writer.WriteCollectionOfObjectValues<VpnDnsRule>("dnsRules", DnsRules);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsSuffixes", DnsSuffixes);
            writer.WriteByteArrayValue("eapXml", EapXml);
            writer.WriteBoolValue("enableAlwaysOn", EnableAlwaysOn);
            writer.WriteBoolValue("enableConditionalAccess", EnableConditionalAccess);
            writer.WriteBoolValue("enableDeviceTunnel", EnableDeviceTunnel);
            writer.WriteBoolValue("enableDnsRegistration", EnableDnsRegistration);
            writer.WriteBoolValue("enableSingleSignOnWithAlternateCertificate", EnableSingleSignOnWithAlternateCertificate);
            writer.WriteBoolValue("enableSplitTunneling", EnableSplitTunneling);
            writer.WriteObjectValue<WindowsCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("microsoftTunnelSiteId", MicrosoftTunnelSiteId);
            writer.WriteBoolValue("onlyAssociatedAppsCanUseConnection", OnlyAssociatedAppsCanUseConnection);
            writer.WriteEnumValue<Windows10VpnProfileTarget>("profileTarget", ProfileTarget);
            writer.WriteObjectValue<Windows10VpnProxyServer>("proxyServer", ProxyServer);
            writer.WriteBoolValue("rememberUserCredentials", RememberUserCredentials);
            writer.WriteCollectionOfObjectValues<VpnRoute>("routes", Routes);
            writer.WriteObjectValue<ExtendedKeyUsage>("singleSignOnEku", SingleSignOnEku);
            writer.WriteStringValue("singleSignOnIssuerHash", SingleSignOnIssuerHash);
            writer.WriteCollectionOfObjectValues<VpnTrafficRule>("trafficRules", TrafficRules);
            writer.WriteCollectionOfPrimitiveValues<string>("trustedNetworkDomains", TrustedNetworkDomains);
            writer.WriteStringValue("windowsInformationProtectionDomain", WindowsInformationProtectionDomain);
        }
    }
}
