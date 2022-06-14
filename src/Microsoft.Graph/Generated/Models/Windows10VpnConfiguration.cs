using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10VpnConfiguration : WindowsVpnConfiguration, IParsable {
        /// <summary>Associated Apps. This collection can contain a maximum of 10000 elements.</summary>
        public List<Windows10AssociatedApps> AssociatedApps {
            get { return BackingStore?.Get<List<Windows10AssociatedApps>>(nameof(AssociatedApps)); }
            set { BackingStore?.Set(nameof(AssociatedApps), value); }
        }
        /// <summary>Authentication method. Possible values are: certificate, usernameAndPassword, customEapXml, derivedCredential.</summary>
        public Windows10VpnAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<Windows10VpnAuthenticationMethod?>(nameof(AuthenticationMethod)); }
            set { BackingStore?.Set(nameof(AuthenticationMethod), value); }
        }
        /// <summary>Connection type. Possible values are: pulseSecure, f5EdgeClient, dellSonicWallMobileConnect, checkPointCapsuleVpn, automatic, ikEv2, l2tp, pptp, citrix, paloAltoGlobalProtect, ciscoAnyConnect, unknownFutureValue, microsoftTunnel.</summary>
        public Windows10VpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<Windows10VpnConnectionType?>(nameof(ConnectionType)); }
            set { BackingStore?.Set(nameof(ConnectionType), value); }
        }
        /// <summary>Cryptography Suite security settings for IKEv2 VPN in Windows10 and above</summary>
        public Microsoft.Graph.Beta.Models.CryptographySuite CryptographySuite {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CryptographySuite>(nameof(CryptographySuite)); }
            set { BackingStore?.Set(nameof(CryptographySuite), value); }
        }
        /// <summary>DNS rules. This collection can contain a maximum of 1000 elements.</summary>
        public List<VpnDnsRule> DnsRules {
            get { return BackingStore?.Get<List<VpnDnsRule>>(nameof(DnsRules)); }
            set { BackingStore?.Set(nameof(DnsRules), value); }
        }
        /// <summary>Specify DNS suffixes to add to the DNS search list to properly route short names.</summary>
        public List<string> DnsSuffixes {
            get { return BackingStore?.Get<List<string>>(nameof(DnsSuffixes)); }
            set { BackingStore?.Set(nameof(DnsSuffixes), value); }
        }
        /// <summary>Extensible Authentication Protocol (EAP) XML. (UTF8 encoded byte array)</summary>
        public byte[] EapXml {
            get { return BackingStore?.Get<byte[]>(nameof(EapXml)); }
            set { BackingStore?.Set(nameof(EapXml), value); }
        }
        /// <summary>Enable Always On mode.</summary>
        public bool? EnableAlwaysOn {
            get { return BackingStore?.Get<bool?>(nameof(EnableAlwaysOn)); }
            set { BackingStore?.Set(nameof(EnableAlwaysOn), value); }
        }
        /// <summary>Enable conditional access.</summary>
        public bool? EnableConditionalAccess {
            get { return BackingStore?.Get<bool?>(nameof(EnableConditionalAccess)); }
            set { BackingStore?.Set(nameof(EnableConditionalAccess), value); }
        }
        /// <summary>Enable device tunnel.</summary>
        public bool? EnableDeviceTunnel {
            get { return BackingStore?.Get<bool?>(nameof(EnableDeviceTunnel)); }
            set { BackingStore?.Set(nameof(EnableDeviceTunnel), value); }
        }
        /// <summary>Enable IP address registration with internal DNS.</summary>
        public bool? EnableDnsRegistration {
            get { return BackingStore?.Get<bool?>(nameof(EnableDnsRegistration)); }
            set { BackingStore?.Set(nameof(EnableDnsRegistration), value); }
        }
        /// <summary>Enable single sign-on (SSO) with alternate certificate.</summary>
        public bool? EnableSingleSignOnWithAlternateCertificate {
            get { return BackingStore?.Get<bool?>(nameof(EnableSingleSignOnWithAlternateCertificate)); }
            set { BackingStore?.Set(nameof(EnableSingleSignOnWithAlternateCertificate), value); }
        }
        /// <summary>Enable split tunneling.</summary>
        public bool? EnableSplitTunneling {
            get { return BackingStore?.Get<bool?>(nameof(EnableSplitTunneling)); }
            set { BackingStore?.Set(nameof(EnableSplitTunneling), value); }
        }
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
        public WindowsCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<WindowsCertificateProfileBase>(nameof(IdentityCertificate)); }
            set { BackingStore?.Set(nameof(IdentityCertificate), value); }
        }
        /// <summary>ID of the Microsoft Tunnel site associated with the VPN profile.</summary>
        public string MicrosoftTunnelSiteId {
            get { return BackingStore?.Get<string>(nameof(MicrosoftTunnelSiteId)); }
            set { BackingStore?.Set(nameof(MicrosoftTunnelSiteId), value); }
        }
        /// <summary>Only associated Apps can use connection (per-app VPN).</summary>
        public bool? OnlyAssociatedAppsCanUseConnection {
            get { return BackingStore?.Get<bool?>(nameof(OnlyAssociatedAppsCanUseConnection)); }
            set { BackingStore?.Set(nameof(OnlyAssociatedAppsCanUseConnection), value); }
        }
        /// <summary>Profile target type. Possible values are: user, device, autoPilotDevice.</summary>
        public Windows10VpnProfileTarget? ProfileTarget {
            get { return BackingStore?.Get<Windows10VpnProfileTarget?>(nameof(ProfileTarget)); }
            set { BackingStore?.Set(nameof(ProfileTarget), value); }
        }
        /// <summary>Proxy Server.</summary>
        public Windows10VpnProxyServer ProxyServer {
            get { return BackingStore?.Get<Windows10VpnProxyServer>(nameof(ProxyServer)); }
            set { BackingStore?.Set(nameof(ProxyServer), value); }
        }
        /// <summary>Remember user credentials.</summary>
        public bool? RememberUserCredentials {
            get { return BackingStore?.Get<bool?>(nameof(RememberUserCredentials)); }
            set { BackingStore?.Set(nameof(RememberUserCredentials), value); }
        }
        /// <summary>Routes (optional for third-party providers). This collection can contain a maximum of 1000 elements.</summary>
        public List<VpnRoute> Routes {
            get { return BackingStore?.Get<List<VpnRoute>>(nameof(Routes)); }
            set { BackingStore?.Set(nameof(Routes), value); }
        }
        /// <summary>Single sign-on Extended Key Usage (EKU).</summary>
        public ExtendedKeyUsage SingleSignOnEku {
            get { return BackingStore?.Get<ExtendedKeyUsage>(nameof(SingleSignOnEku)); }
            set { BackingStore?.Set(nameof(SingleSignOnEku), value); }
        }
        /// <summary>Single sign-on issuer hash.</summary>
        public string SingleSignOnIssuerHash {
            get { return BackingStore?.Get<string>(nameof(SingleSignOnIssuerHash)); }
            set { BackingStore?.Set(nameof(SingleSignOnIssuerHash), value); }
        }
        /// <summary>Traffic rules. This collection can contain a maximum of 1000 elements.</summary>
        public List<VpnTrafficRule> TrafficRules {
            get { return BackingStore?.Get<List<VpnTrafficRule>>(nameof(TrafficRules)); }
            set { BackingStore?.Set(nameof(TrafficRules), value); }
        }
        /// <summary>Trusted Network Domains</summary>
        public List<string> TrustedNetworkDomains {
            get { return BackingStore?.Get<List<string>>(nameof(TrustedNetworkDomains)); }
            set { BackingStore?.Set(nameof(TrustedNetworkDomains), value); }
        }
        /// <summary>Windows Information Protection (WIP) domain to associate with this connection.</summary>
        public string WindowsInformationProtectionDomain {
            get { return BackingStore?.Get<string>(nameof(WindowsInformationProtectionDomain)); }
            set { BackingStore?.Set(nameof(WindowsInformationProtectionDomain), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10VpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10VpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associatedApps", n => { AssociatedApps = n.GetCollectionOfObjectValues<Windows10AssociatedApps>(Windows10AssociatedApps.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<Windows10VpnAuthenticationMethod>(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<Windows10VpnConnectionType>(); } },
                {"cryptographySuite", n => { CryptographySuite = n.GetObjectValue<Microsoft.Graph.Beta.Models.CryptographySuite>(Microsoft.Graph.Beta.Models.CryptographySuite.CreateFromDiscriminatorValue); } },
                {"dnsRules", n => { DnsRules = n.GetCollectionOfObjectValues<VpnDnsRule>(VpnDnsRule.CreateFromDiscriminatorValue).ToList(); } },
                {"dnsSuffixes", n => { DnsSuffixes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
                {"routes", n => { Routes = n.GetCollectionOfObjectValues<VpnRoute>(VpnRoute.CreateFromDiscriminatorValue).ToList(); } },
                {"singleSignOnEku", n => { SingleSignOnEku = n.GetObjectValue<ExtendedKeyUsage>(ExtendedKeyUsage.CreateFromDiscriminatorValue); } },
                {"singleSignOnIssuerHash", n => { SingleSignOnIssuerHash = n.GetStringValue(); } },
                {"trafficRules", n => { TrafficRules = n.GetCollectionOfObjectValues<VpnTrafficRule>(VpnTrafficRule.CreateFromDiscriminatorValue).ToList(); } },
                {"trustedNetworkDomains", n => { TrustedNetworkDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"windowsInformationProtectionDomain", n => { WindowsInformationProtectionDomain = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
