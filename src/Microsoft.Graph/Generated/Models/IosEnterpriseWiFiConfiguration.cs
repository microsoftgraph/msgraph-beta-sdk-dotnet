using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosEnterpriseWiFiConfiguration : IosWiFiConfiguration, IParsable {
        /// <summary>Authentication Method when EAP Type is configured to PEAP or EAP-TTLS. Possible values are: certificate, usernameAndPassword, derivedCredential.</summary>
        public WiFiAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<WiFiAuthenticationMethod?>(nameof(AuthenticationMethod)); }
            set { BackingStore?.Set(nameof(AuthenticationMethod), value); }
        }
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings>(nameof(DerivedCredentialSettings)); }
            set { BackingStore?.Set(nameof(DerivedCredentialSettings), value); }
        }
        /// <summary>EAP-FAST Configuration Option when EAP-FAST is the selected EAP Type. Possible values are: noProtectedAccessCredential, useProtectedAccessCredential, useProtectedAccessCredentialAndProvision, useProtectedAccessCredentialAndProvisionAnonymously.</summary>
        public Microsoft.Graph.Beta.Models.EapFastConfiguration? EapFastConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EapFastConfiguration?>(nameof(EapFastConfiguration)); }
            set { BackingStore?.Set(nameof(EapFastConfiguration), value); }
        }
        /// <summary>Extensible Authentication Protocol (EAP). Indicates the type of EAP protocol set on the Wi-Fi endpoint (router). Possible values are: eapTls, leap, eapSim, eapTtls, peap, eapFast, teap.</summary>
        public Microsoft.Graph.Beta.Models.EapType? EapType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EapType?>(nameof(EapType)); }
            set { BackingStore?.Set(nameof(EapType), value); }
        }
        /// <summary>Identity Certificate for client authentication when EAP Type is configured to EAP-TLS, EAP-TTLS (with Certificate Authentication), or PEAP (with Certificate Authentication).</summary>
        public IosCertificateProfileBase IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<IosCertificateProfileBase>(nameof(IdentityCertificateForClientAuthentication)); }
            set { BackingStore?.Set(nameof(IdentityCertificateForClientAuthentication), value); }
        }
        /// <summary>Non-EAP Method for Authentication when EAP Type is EAP-TTLS and Authenticationmethod is Username and Password. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo.</summary>
        public NonEapAuthenticationMethodForEapTtlsType? InnerAuthenticationProtocolForEapTtls {
            get { return BackingStore?.Get<NonEapAuthenticationMethodForEapTtlsType?>(nameof(InnerAuthenticationProtocolForEapTtls)); }
            set { BackingStore?.Set(nameof(InnerAuthenticationProtocolForEapTtls), value); }
        }
        /// <summary>Enable identity privacy (Outer Identity) when EAP Type is configured to EAP - TTLS, EAP - FAST or PEAP. This property masks usernames with the text you enter. For example, if you use &apos;anonymous&apos;, each user that authenticates with this Wi-Fi connection using their real username is displayed as &apos;anonymous&apos;.</summary>
        public string OuterIdentityPrivacyTemporaryValue {
            get { return BackingStore?.Get<string>(nameof(OuterIdentityPrivacyTemporaryValue)); }
            set { BackingStore?.Set(nameof(OuterIdentityPrivacyTemporaryValue), value); }
        }
        /// <summary>Password format string used to build the password to connect to wifi</summary>
        public string PasswordFormatString {
            get { return BackingStore?.Get<string>(nameof(PasswordFormatString)); }
            set { BackingStore?.Set(nameof(PasswordFormatString), value); }
        }
        /// <summary>Trusted Root Certificates for Server Validation when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. If you provide this value you do not need to provide trustedServerCertificateNames, and vice versa. This collection can contain a maximum of 500 elements.</summary>
        public List<IosTrustedRootCertificate> RootCertificatesForServerValidation {
            get { return BackingStore?.Get<List<IosTrustedRootCertificate>>(nameof(RootCertificatesForServerValidation)); }
            set { BackingStore?.Set(nameof(RootCertificatesForServerValidation), value); }
        }
        /// <summary>Trusted server certificate names when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. This is the common name used in the certificates issued by your trusted certificate authority (CA). If you provide this information, you can bypass the dynamic trust dialog that is displayed on end users&apos; devices when they connect to this Wi-Fi network.</summary>
        public List<string> TrustedServerCertificateNames {
            get { return BackingStore?.Get<List<string>>(nameof(TrustedServerCertificateNames)); }
            set { BackingStore?.Set(nameof(TrustedServerCertificateNames), value); }
        }
        /// <summary>Username format string used to build the username to connect to wifi</summary>
        public string UsernameFormatString {
            get { return BackingStore?.Get<string>(nameof(UsernameFormatString)); }
            set { BackingStore?.Set(nameof(UsernameFormatString), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosEnterpriseWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosEnterpriseWiFiConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<WiFiAuthenticationMethod>(); } },
                {"derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                {"eapFastConfiguration", n => { EapFastConfiguration = n.GetEnumValue<EapFastConfiguration>(); } },
                {"eapType", n => { EapType = n.GetEnumValue<EapType>(); } },
                {"identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<IosCertificateProfileBase>(IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"innerAuthenticationProtocolForEapTtls", n => { InnerAuthenticationProtocolForEapTtls = n.GetEnumValue<NonEapAuthenticationMethodForEapTtlsType>(); } },
                {"outerIdentityPrivacyTemporaryValue", n => { OuterIdentityPrivacyTemporaryValue = n.GetStringValue(); } },
                {"passwordFormatString", n => { PasswordFormatString = n.GetStringValue(); } },
                {"rootCertificatesForServerValidation", n => { RootCertificatesForServerValidation = n.GetCollectionOfObjectValues<IosTrustedRootCertificate>(IosTrustedRootCertificate.CreateFromDiscriminatorValue).ToList(); } },
                {"trustedServerCertificateNames", n => { TrustedServerCertificateNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"usernameFormatString", n => { UsernameFormatString = n.GetStringValue(); } },
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
            writer.WriteObjectValue<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteEnumValue<EapFastConfiguration>("eapFastConfiguration", EapFastConfiguration);
            writer.WriteEnumValue<EapType>("eapType", EapType);
            writer.WriteObjectValue<IosCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteEnumValue<NonEapAuthenticationMethodForEapTtlsType>("innerAuthenticationProtocolForEapTtls", InnerAuthenticationProtocolForEapTtls);
            writer.WriteStringValue("outerIdentityPrivacyTemporaryValue", OuterIdentityPrivacyTemporaryValue);
            writer.WriteStringValue("passwordFormatString", PasswordFormatString);
            writer.WriteCollectionOfObjectValues<IosTrustedRootCertificate>("rootCertificatesForServerValidation", RootCertificatesForServerValidation);
            writer.WriteCollectionOfPrimitiveValues<string>("trustedServerCertificateNames", TrustedServerCertificateNames);
            writer.WriteStringValue("usernameFormatString", UsernameFormatString);
        }
    }
}
