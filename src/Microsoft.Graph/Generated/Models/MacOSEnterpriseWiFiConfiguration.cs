using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSEnterpriseWiFiConfiguration : MacOSWiFiConfiguration, IParsable {
        /// <summary>Authentication Method when EAP Type is configured to PEAP or EAP-TTLS. Possible values are: certificate, usernameAndPassword, derivedCredential.</summary>
        public WiFiAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<WiFiAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>EAP-FAST Configuration Option when EAP-FAST is the selected EAP Type. Possible values are: noProtectedAccessCredential, useProtectedAccessCredential, useProtectedAccessCredentialAndProvision, useProtectedAccessCredentialAndProvisionAnonymously.</summary>
        public Microsoft.Graph.Beta.Models.EapFastConfiguration? EapFastConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EapFastConfiguration?>("eapFastConfiguration"); }
            set { BackingStore?.Set("eapFastConfiguration", value); }
        }
        /// <summary>Extensible Authentication Protocol (EAP) configuration types.</summary>
        public Microsoft.Graph.Beta.Models.EapType? EapType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EapType?>("eapType"); }
            set { BackingStore?.Set("eapType", value); }
        }
        /// <summary>Identity Certificate for client authentication when EAP Type is configured to EAP-TLS, EAP-TTLS (with Certificate Authentication), or PEAP (with Certificate Authentication).</summary>
        public MacOSCertificateProfileBase IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<MacOSCertificateProfileBase>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
        /// <summary>Non-EAP Method for Authentication (Inner Identity) when EAP Type is EAP-TTLS and Authenticationmethod is Username and Password. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo.</summary>
        public NonEapAuthenticationMethodForEapTtlsType? InnerAuthenticationProtocolForEapTtls {
            get { return BackingStore?.Get<NonEapAuthenticationMethodForEapTtlsType?>("innerAuthenticationProtocolForEapTtls"); }
            set { BackingStore?.Set("innerAuthenticationProtocolForEapTtls", value); }
        }
        /// <summary>Enable identity privacy (Outer Identity) when EAP Type is configured to EAP-TTLS, EAP-FAST or PEAP. This property masks usernames with the text you enter. For example, if you use &apos;anonymous&apos;, each user that authenticates with this Wi-Fi connection using their real username is displayed as &apos;anonymous&apos;.</summary>
        public string OuterIdentityPrivacyTemporaryValue {
            get { return BackingStore?.Get<string>("outerIdentityPrivacyTemporaryValue"); }
            set { BackingStore?.Set("outerIdentityPrivacyTemporaryValue", value); }
        }
        /// <summary>Trusted Root Certificate for Server Validation when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP.</summary>
        public MacOSTrustedRootCertificate RootCertificateForServerValidation {
            get { return BackingStore?.Get<MacOSTrustedRootCertificate>("rootCertificateForServerValidation"); }
            set { BackingStore?.Set("rootCertificateForServerValidation", value); }
        }
        /// <summary>Trusted Root Certificates for Server Validation when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. If you provide this value you do not need to provide trustedServerCertificateNames, and vice versa. This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSTrustedRootCertificate> RootCertificatesForServerValidation {
            get { return BackingStore?.Get<List<MacOSTrustedRootCertificate>>("rootCertificatesForServerValidation"); }
            set { BackingStore?.Set("rootCertificatesForServerValidation", value); }
        }
        /// <summary>Trusted server certificate names when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. This is the common name used in the certificates issued by your trusted certificate authority (CA). If you provide this information, you can bypass the dynamic trust dialog that is displayed on end users devices when they connect to this Wi-Fi network.</summary>
        public List<string> TrustedServerCertificateNames {
            get { return BackingStore?.Get<List<string>>("trustedServerCertificateNames"); }
            set { BackingStore?.Set("trustedServerCertificateNames", value); }
        }
        /// <summary>
        /// Instantiates a new MacOSEnterpriseWiFiConfiguration and sets the default values.
        /// </summary>
        public MacOSEnterpriseWiFiConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSEnterpriseWiFiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSEnterpriseWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSEnterpriseWiFiConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<WiFiAuthenticationMethod>(); } },
                {"eapFastConfiguration", n => { EapFastConfiguration = n.GetEnumValue<EapFastConfiguration>(); } },
                {"eapType", n => { EapType = n.GetEnumValue<EapType>(); } },
                {"identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<MacOSCertificateProfileBase>(MacOSCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"innerAuthenticationProtocolForEapTtls", n => { InnerAuthenticationProtocolForEapTtls = n.GetEnumValue<NonEapAuthenticationMethodForEapTtlsType>(); } },
                {"outerIdentityPrivacyTemporaryValue", n => { OuterIdentityPrivacyTemporaryValue = n.GetStringValue(); } },
                {"rootCertificateForServerValidation", n => { RootCertificateForServerValidation = n.GetObjectValue<MacOSTrustedRootCertificate>(MacOSTrustedRootCertificate.CreateFromDiscriminatorValue); } },
                {"rootCertificatesForServerValidation", n => { RootCertificatesForServerValidation = n.GetCollectionOfObjectValues<MacOSTrustedRootCertificate>(MacOSTrustedRootCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trustedServerCertificateNames", n => { TrustedServerCertificateNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WiFiAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteEnumValue<EapFastConfiguration>("eapFastConfiguration", EapFastConfiguration);
            writer.WriteEnumValue<EapType>("eapType", EapType);
            writer.WriteObjectValue<MacOSCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteEnumValue<NonEapAuthenticationMethodForEapTtlsType>("innerAuthenticationProtocolForEapTtls", InnerAuthenticationProtocolForEapTtls);
            writer.WriteStringValue("outerIdentityPrivacyTemporaryValue", OuterIdentityPrivacyTemporaryValue);
            writer.WriteObjectValue<MacOSTrustedRootCertificate>("rootCertificateForServerValidation", RootCertificateForServerValidation);
            writer.WriteCollectionOfObjectValues<MacOSTrustedRootCertificate>("rootCertificatesForServerValidation", RootCertificatesForServerValidation);
            writer.WriteCollectionOfPrimitiveValues<string>("trustedServerCertificateNames", TrustedServerCertificateNames);
        }
    }
}
