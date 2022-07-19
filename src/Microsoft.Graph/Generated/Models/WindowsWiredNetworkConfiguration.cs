using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsWiredNetworkConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Specify the duration for which automatic authentication attempts will be blocked from occuring after a failed authentication attempt.</summary>
        public int? AuthenticationBlockPeriodInMinutes {
            get { return BackingStore?.Get<int?>("authenticationBlockPeriodInMinutes"); }
            set { BackingStore?.Set("authenticationBlockPeriodInMinutes", value); }
        }
        /// <summary>Specify the authentication method. Possible values are: certificate, usernameAndPassword, derivedCredential. Possible values are: certificate, usernameAndPassword, derivedCredential, unknownFutureValue.</summary>
        public WiredNetworkAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<WiredNetworkAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Specify the number of seconds for the client to wait after an authentication attempt before failing. Valid range 1-3600.</summary>
        public int? AuthenticationPeriodInSeconds {
            get { return BackingStore?.Get<int?>("authenticationPeriodInSeconds"); }
            set { BackingStore?.Set("authenticationPeriodInSeconds", value); }
        }
        /// <summary>Specify the number of seconds between a failed authentication and the next authentication attempt. Valid range 1-3600.</summary>
        public int? AuthenticationRetryDelayPeriodInSeconds {
            get { return BackingStore?.Get<int?>("authenticationRetryDelayPeriodInSeconds"); }
            set { BackingStore?.Set("authenticationRetryDelayPeriodInSeconds", value); }
        }
        /// <summary>Specify whether to authenticate the user, the device, either, or to use guest authentication (none). If you&apos;re using certificate authentication, make sure the certificate type matches the authentication type. Possible values are: none, user, machine, machineOrUser, guest. Possible values are: none, user, machine, machineOrUser, guest, unknownFutureValue.</summary>
        public WiredNetworkAuthenticationType? AuthenticationType {
            get { return BackingStore?.Get<WiredNetworkAuthenticationType?>("authenticationType"); }
            set { BackingStore?.Set("authenticationType", value); }
        }
        /// <summary>When TRUE, caches user credentials on the device so that users don&apos;t need to keep entering them each time they connect. When FALSE, do not cache credentials. Default value is FALSE.</summary>
        public bool? CacheCredentials {
            get { return BackingStore?.Get<bool?>("cacheCredentials"); }
            set { BackingStore?.Set("cacheCredentials", value); }
        }
        /// <summary>When TRUE, prevents the user from being prompted to authorize new servers for trusted certification authorities when EAP type is selected as PEAP. When FALSE, does not prevent the user from being prompted. Default value is FALSE.</summary>
        public bool? DisableUserPromptForServerValidation {
            get { return BackingStore?.Get<bool?>("disableUserPromptForServerValidation"); }
            set { BackingStore?.Set("disableUserPromptForServerValidation", value); }
        }
        /// <summary>Specify the number of seconds to wait before sending an EAPOL (Extensible Authentication Protocol over LAN) Start message. Valid range 1-3600.</summary>
        public int? EapolStartPeriodInSeconds {
            get { return BackingStore?.Get<int?>("eapolStartPeriodInSeconds"); }
            set { BackingStore?.Set("eapolStartPeriodInSeconds", value); }
        }
        /// <summary>Extensible Authentication Protocol (EAP) configuration types.</summary>
        public Microsoft.Graph.Beta.Models.EapType? EapType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EapType?>("eapType"); }
            set { BackingStore?.Set("eapType", value); }
        }
        /// <summary>When TRUE, the automatic configuration service for wired networks requires the use of 802.1X for port authentication. When FALSE, 802.1X is not required. Default value is FALSE.</summary>
        public bool? Enforce8021X {
            get { return BackingStore?.Get<bool?>("enforce8021X"); }
            set { BackingStore?.Set("enforce8021X", value); }
        }
        /// <summary>When TRUE, forces FIPS compliance. When FALSE, does not enable FIPS compliance. Default value is FALSE.</summary>
        public bool? ForceFIPSCompliance {
            get { return BackingStore?.Get<bool?>("forceFIPSCompliance"); }
            set { BackingStore?.Set("forceFIPSCompliance", value); }
        }
        /// <summary>Specify identity certificate for client authentication.</summary>
        public WindowsCertificateProfileBase IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<WindowsCertificateProfileBase>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
        /// <summary>Specify inner authentication protocol for EAP TTLS. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo.</summary>
        public NonEapAuthenticationMethodForEapTtlsType? InnerAuthenticationProtocolForEAPTTLS {
            get { return BackingStore?.Get<NonEapAuthenticationMethodForEapTtlsType?>("innerAuthenticationProtocolForEAPTTLS"); }
            set { BackingStore?.Set("innerAuthenticationProtocolForEAPTTLS", value); }
        }
        /// <summary>Specify the maximum authentication failures allowed for a set of credentials. Valid range 1-100.</summary>
        public int? MaximumAuthenticationFailures {
            get { return BackingStore?.Get<int?>("maximumAuthenticationFailures"); }
            set { BackingStore?.Set("maximumAuthenticationFailures", value); }
        }
        /// <summary>Specify the maximum number of EAPOL (Extensible Authentication Protocol over LAN) Start messages to be sent before returning failure. Valid range 1-100.</summary>
        public int? MaximumEAPOLStartMessages {
            get { return BackingStore?.Get<int?>("maximumEAPOLStartMessages"); }
            set { BackingStore?.Set("maximumEAPOLStartMessages", value); }
        }
        /// <summary>Specify the string to replace usernames for privacy when using EAP TTLS or PEAP.</summary>
        public string OuterIdentityPrivacyTemporaryValue {
            get { return BackingStore?.Get<string>("outerIdentityPrivacyTemporaryValue"); }
            set { BackingStore?.Set("outerIdentityPrivacyTemporaryValue", value); }
        }
        /// <summary>When TRUE, enables verification of server&apos;s identity by validating the certificate when EAP type is selected as PEAP. When FALSE, the certificate is not validated. Default value is TRUE.</summary>
        public bool? PerformServerValidation {
            get { return BackingStore?.Get<bool?>("performServerValidation"); }
            set { BackingStore?.Set("performServerValidation", value); }
        }
        /// <summary>When TRUE, enables cryptographic binding when EAP type is selected as PEAP. When FALSE, does not enable cryptogrpahic binding. Default value is TRUE.</summary>
        public bool? RequireCryptographicBinding {
            get { return BackingStore?.Get<bool?>("requireCryptographicBinding"); }
            set { BackingStore?.Set("requireCryptographicBinding", value); }
        }
        /// <summary>Specify root certificate for client validation.</summary>
        public Windows81TrustedRootCertificate RootCertificateForClientValidation {
            get { return BackingStore?.Get<Windows81TrustedRootCertificate>("rootCertificateForClientValidation"); }
            set { BackingStore?.Set("rootCertificateForClientValidation", value); }
        }
        /// <summary>Specify root certificates for server validation. This collection can contain a maximum of 500 elements.</summary>
        public List<Windows81TrustedRootCertificate> RootCertificatesForServerValidation {
            get { return BackingStore?.Get<List<Windows81TrustedRootCertificate>>("rootCertificatesForServerValidation"); }
            set { BackingStore?.Set("rootCertificatesForServerValidation", value); }
        }
        /// <summary>Specify the secondary authentication method. Possible values are: certificate, usernameAndPassword, derivedCredential. Possible values are: certificate, usernameAndPassword, derivedCredential, unknownFutureValue.</summary>
        public WiredNetworkAuthenticationMethod? SecondaryAuthenticationMethod {
            get { return BackingStore?.Get<WiredNetworkAuthenticationMethod?>("secondaryAuthenticationMethod"); }
            set { BackingStore?.Set("secondaryAuthenticationMethod", value); }
        }
        /// <summary>Specify secondary identity certificate for client authentication.</summary>
        public WindowsCertificateProfileBase SecondaryIdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<WindowsCertificateProfileBase>("secondaryIdentityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("secondaryIdentityCertificateForClientAuthentication", value); }
        }
        /// <summary>Specify secondary root certificate for client validation.</summary>
        public Windows81TrustedRootCertificate SecondaryRootCertificateForClientValidation {
            get { return BackingStore?.Get<Windows81TrustedRootCertificate>("secondaryRootCertificateForClientValidation"); }
            set { BackingStore?.Set("secondaryRootCertificateForClientValidation", value); }
        }
        /// <summary>Specify trusted server certificate names.</summary>
        public List<string> TrustedServerCertificateNames {
            get { return BackingStore?.Get<List<string>>("trustedServerCertificateNames"); }
            set { BackingStore?.Set("trustedServerCertificateNames", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsWiredNetworkConfiguration and sets the default values.
        /// </summary>
        public WindowsWiredNetworkConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsWiredNetworkConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsWiredNetworkConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsWiredNetworkConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationBlockPeriodInMinutes", n => { AuthenticationBlockPeriodInMinutes = n.GetIntValue(); } },
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<WiredNetworkAuthenticationMethod>(); } },
                {"authenticationPeriodInSeconds", n => { AuthenticationPeriodInSeconds = n.GetIntValue(); } },
                {"authenticationRetryDelayPeriodInSeconds", n => { AuthenticationRetryDelayPeriodInSeconds = n.GetIntValue(); } },
                {"authenticationType", n => { AuthenticationType = n.GetEnumValue<WiredNetworkAuthenticationType>(); } },
                {"cacheCredentials", n => { CacheCredentials = n.GetBoolValue(); } },
                {"disableUserPromptForServerValidation", n => { DisableUserPromptForServerValidation = n.GetBoolValue(); } },
                {"eapolStartPeriodInSeconds", n => { EapolStartPeriodInSeconds = n.GetIntValue(); } },
                {"eapType", n => { EapType = n.GetEnumValue<EapType>(); } },
                {"enforce8021X", n => { Enforce8021X = n.GetBoolValue(); } },
                {"forceFIPSCompliance", n => { ForceFIPSCompliance = n.GetBoolValue(); } },
                {"identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<WindowsCertificateProfileBase>(WindowsCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"innerAuthenticationProtocolForEAPTTLS", n => { InnerAuthenticationProtocolForEAPTTLS = n.GetEnumValue<NonEapAuthenticationMethodForEapTtlsType>(); } },
                {"maximumAuthenticationFailures", n => { MaximumAuthenticationFailures = n.GetIntValue(); } },
                {"maximumEAPOLStartMessages", n => { MaximumEAPOLStartMessages = n.GetIntValue(); } },
                {"outerIdentityPrivacyTemporaryValue", n => { OuterIdentityPrivacyTemporaryValue = n.GetStringValue(); } },
                {"performServerValidation", n => { PerformServerValidation = n.GetBoolValue(); } },
                {"requireCryptographicBinding", n => { RequireCryptographicBinding = n.GetBoolValue(); } },
                {"rootCertificateForClientValidation", n => { RootCertificateForClientValidation = n.GetObjectValue<Windows81TrustedRootCertificate>(Windows81TrustedRootCertificate.CreateFromDiscriminatorValue); } },
                {"rootCertificatesForServerValidation", n => { RootCertificatesForServerValidation = n.GetCollectionOfObjectValues<Windows81TrustedRootCertificate>(Windows81TrustedRootCertificate.CreateFromDiscriminatorValue).ToList(); } },
                {"secondaryAuthenticationMethod", n => { SecondaryAuthenticationMethod = n.GetEnumValue<WiredNetworkAuthenticationMethod>(); } },
                {"secondaryIdentityCertificateForClientAuthentication", n => { SecondaryIdentityCertificateForClientAuthentication = n.GetObjectValue<WindowsCertificateProfileBase>(WindowsCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"secondaryRootCertificateForClientValidation", n => { SecondaryRootCertificateForClientValidation = n.GetObjectValue<Windows81TrustedRootCertificate>(Windows81TrustedRootCertificate.CreateFromDiscriminatorValue); } },
                {"trustedServerCertificateNames", n => { TrustedServerCertificateNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("authenticationBlockPeriodInMinutes", AuthenticationBlockPeriodInMinutes);
            writer.WriteEnumValue<WiredNetworkAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteIntValue("authenticationPeriodInSeconds", AuthenticationPeriodInSeconds);
            writer.WriteIntValue("authenticationRetryDelayPeriodInSeconds", AuthenticationRetryDelayPeriodInSeconds);
            writer.WriteEnumValue<WiredNetworkAuthenticationType>("authenticationType", AuthenticationType);
            writer.WriteBoolValue("cacheCredentials", CacheCredentials);
            writer.WriteBoolValue("disableUserPromptForServerValidation", DisableUserPromptForServerValidation);
            writer.WriteIntValue("eapolStartPeriodInSeconds", EapolStartPeriodInSeconds);
            writer.WriteEnumValue<EapType>("eapType", EapType);
            writer.WriteBoolValue("enforce8021X", Enforce8021X);
            writer.WriteBoolValue("forceFIPSCompliance", ForceFIPSCompliance);
            writer.WriteObjectValue<WindowsCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteEnumValue<NonEapAuthenticationMethodForEapTtlsType>("innerAuthenticationProtocolForEAPTTLS", InnerAuthenticationProtocolForEAPTTLS);
            writer.WriteIntValue("maximumAuthenticationFailures", MaximumAuthenticationFailures);
            writer.WriteIntValue("maximumEAPOLStartMessages", MaximumEAPOLStartMessages);
            writer.WriteStringValue("outerIdentityPrivacyTemporaryValue", OuterIdentityPrivacyTemporaryValue);
            writer.WriteBoolValue("performServerValidation", PerformServerValidation);
            writer.WriteBoolValue("requireCryptographicBinding", RequireCryptographicBinding);
            writer.WriteObjectValue<Windows81TrustedRootCertificate>("rootCertificateForClientValidation", RootCertificateForClientValidation);
            writer.WriteCollectionOfObjectValues<Windows81TrustedRootCertificate>("rootCertificatesForServerValidation", RootCertificatesForServerValidation);
            writer.WriteEnumValue<WiredNetworkAuthenticationMethod>("secondaryAuthenticationMethod", SecondaryAuthenticationMethod);
            writer.WriteObjectValue<WindowsCertificateProfileBase>("secondaryIdentityCertificateForClientAuthentication", SecondaryIdentityCertificateForClientAuthentication);
            writer.WriteObjectValue<Windows81TrustedRootCertificate>("secondaryRootCertificateForClientValidation", SecondaryRootCertificateForClientValidation);
            writer.WriteCollectionOfPrimitiveValues<string>("trustedServerCertificateNames", TrustedServerCertificateNames);
        }
    }
}
