using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidWorkProfileEnterpriseWiFiConfiguration : AndroidWorkProfileWiFiConfiguration, IParsable {
        /// <summary>Indicates the Authentication Method the client (device) needs to use when the EAP Type is configured to PEAP or EAP-TTLS. Possible values are: certificate, usernameAndPassword, derivedCredential.</summary>
        public WiFiAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<WiFiAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Extensible Authentication Protocol (EAP) Configuration Types.</summary>
        public AndroidEapType? EapType {
            get { return BackingStore?.Get<AndroidEapType?>("eapType"); }
            set { BackingStore?.Set("eapType", value); }
        }
        /// <summary>Identity Certificate for client authentication when EAP Type is configured to EAP-TLS, EAP-TTLS (with Certificate Authentication), or PEAP (with Certificate Authentication). This is the certificate presented by client to the Wi-Fi endpoint. The authentication server sitting behind the Wi-Fi endpoint must accept this certificate to successfully establish a Wi-Fi connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidWorkProfileCertificateProfileBase? IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<AndroidWorkProfileCertificateProfileBase?>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#nullable restore
#else
        public AndroidWorkProfileCertificateProfileBase IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<AndroidWorkProfileCertificateProfileBase>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#endif
        /// <summary>Non-EAP Method for Authentication (Inner Identity) when EAP Type is EAP-TTLS and Authenticationmethod is Username and Password. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo.</summary>
        public NonEapAuthenticationMethodForEapTtlsType? InnerAuthenticationProtocolForEapTtls {
            get { return BackingStore?.Get<NonEapAuthenticationMethodForEapTtlsType?>("innerAuthenticationProtocolForEapTtls"); }
            set { BackingStore?.Set("innerAuthenticationProtocolForEapTtls", value); }
        }
        /// <summary>Non-EAP Method for Authentication (Inner Identity) when EAP Type is PEAP and Authenticationmethod is Username and Password. Possible values are: none, microsoftChapVersionTwo.</summary>
        public NonEapAuthenticationMethodForPeap? InnerAuthenticationProtocolForPeap {
            get { return BackingStore?.Get<NonEapAuthenticationMethodForPeap?>("innerAuthenticationProtocolForPeap"); }
            set { BackingStore?.Set("innerAuthenticationProtocolForPeap", value); }
        }
        /// <summary>Enable identity privacy (Outer Identity) when EAP Type is configured to EAP-TTLS or PEAP. The String provided here is used to mask the username of individual users when they attempt to connect to Wi-Fi network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OuterIdentityPrivacyTemporaryValue {
            get { return BackingStore?.Get<string?>("outerIdentityPrivacyTemporaryValue"); }
            set { BackingStore?.Set("outerIdentityPrivacyTemporaryValue", value); }
        }
#nullable restore
#else
        public string OuterIdentityPrivacyTemporaryValue {
            get { return BackingStore?.Get<string>("outerIdentityPrivacyTemporaryValue"); }
            set { BackingStore?.Set("outerIdentityPrivacyTemporaryValue", value); }
        }
#endif
        /// <summary>URL of the proxy server automatic configuration script when automatic configuration is selected. This URL is typically the location of PAC (Proxy Auto Configuration) file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string?>("proxyAutomaticConfigurationUrl"); }
            set { BackingStore?.Set("proxyAutomaticConfigurationUrl", value); }
        }
#nullable restore
#else
        public string ProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string>("proxyAutomaticConfigurationUrl"); }
            set { BackingStore?.Set("proxyAutomaticConfigurationUrl", value); }
        }
#endif
        /// <summary>Wi-Fi Proxy Settings.</summary>
        public WiFiProxySetting? ProxySettings {
            get { return BackingStore?.Get<WiFiProxySetting?>("proxySettings"); }
            set { BackingStore?.Set("proxySettings", value); }
        }
        /// <summary>Trusted Root Certificate for Server Validation when EAP Type is configured to EAP-TLS, EAP-TTLS or PEAP. This is the certificate presented by the Wi-Fi endpoint when the device attempts to connect to Wi-Fi endpoint. The device (or user) must accept this certificate to continue the connection attempt.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidWorkProfileTrustedRootCertificate? RootCertificateForServerValidation {
            get { return BackingStore?.Get<AndroidWorkProfileTrustedRootCertificate?>("rootCertificateForServerValidation"); }
            set { BackingStore?.Set("rootCertificateForServerValidation", value); }
        }
#nullable restore
#else
        public AndroidWorkProfileTrustedRootCertificate RootCertificateForServerValidation {
            get { return BackingStore?.Get<AndroidWorkProfileTrustedRootCertificate>("rootCertificateForServerValidation"); }
            set { BackingStore?.Set("rootCertificateForServerValidation", value); }
        }
#endif
        /// <summary>Trusted server certificate names when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. This is the common name used in the certificates issued by your trusted certificate authority (CA). If you provide this information, you can bypass the dynamic trust dialog that is displayed on end users&apos; devices when they connect to this Wi-Fi network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TrustedServerCertificateNames {
            get { return BackingStore?.Get<List<string>?>("trustedServerCertificateNames"); }
            set { BackingStore?.Set("trustedServerCertificateNames", value); }
        }
#nullable restore
#else
        public List<string> TrustedServerCertificateNames {
            get { return BackingStore?.Get<List<string>>("trustedServerCertificateNames"); }
            set { BackingStore?.Set("trustedServerCertificateNames", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AndroidWorkProfileEnterpriseWiFiConfiguration and sets the default values.
        /// </summary>
        public AndroidWorkProfileEnterpriseWiFiConfiguration() : base() {
            OdataType = "#microsoft.graph.androidWorkProfileEnterpriseWiFiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidWorkProfileEnterpriseWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidWorkProfileEnterpriseWiFiConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<WiFiAuthenticationMethod>(); } },
                {"eapType", n => { EapType = n.GetEnumValue<AndroidEapType>(); } },
                {"identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<AndroidWorkProfileCertificateProfileBase>(AndroidWorkProfileCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"innerAuthenticationProtocolForEapTtls", n => { InnerAuthenticationProtocolForEapTtls = n.GetEnumValue<NonEapAuthenticationMethodForEapTtlsType>(); } },
                {"innerAuthenticationProtocolForPeap", n => { InnerAuthenticationProtocolForPeap = n.GetEnumValue<NonEapAuthenticationMethodForPeap>(); } },
                {"outerIdentityPrivacyTemporaryValue", n => { OuterIdentityPrivacyTemporaryValue = n.GetStringValue(); } },
                {"proxyAutomaticConfigurationUrl", n => { ProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                {"proxySettings", n => { ProxySettings = n.GetEnumValue<WiFiProxySetting>(); } },
                {"rootCertificateForServerValidation", n => { RootCertificateForServerValidation = n.GetObjectValue<AndroidWorkProfileTrustedRootCertificate>(AndroidWorkProfileTrustedRootCertificate.CreateFromDiscriminatorValue); } },
                {"trustedServerCertificateNames", n => { TrustedServerCertificateNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WiFiAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteEnumValue<AndroidEapType>("eapType", EapType);
            writer.WriteObjectValue<AndroidWorkProfileCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteEnumValue<NonEapAuthenticationMethodForEapTtlsType>("innerAuthenticationProtocolForEapTtls", InnerAuthenticationProtocolForEapTtls);
            writer.WriteEnumValue<NonEapAuthenticationMethodForPeap>("innerAuthenticationProtocolForPeap", InnerAuthenticationProtocolForPeap);
            writer.WriteStringValue("outerIdentityPrivacyTemporaryValue", OuterIdentityPrivacyTemporaryValue);
            writer.WriteStringValue("proxyAutomaticConfigurationUrl", ProxyAutomaticConfigurationUrl);
            writer.WriteEnumValue<WiFiProxySetting>("proxySettings", ProxySettings);
            writer.WriteObjectValue<AndroidWorkProfileTrustedRootCertificate>("rootCertificateForServerValidation", RootCertificateForServerValidation);
            writer.WriteCollectionOfPrimitiveValues<string>("trustedServerCertificateNames", TrustedServerCertificateNames);
        }
    }
}
