using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnPremisesPublishing : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.</summary>
        public string AlternateUrl { get; set; }
        /// <summary>The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is &apos;Backend Timeout&apos;. Default value is default.</summary>
        public string ApplicationServerTimeout { get; set; }
        /// <summary>Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.</summary>
        public string ApplicationType { get; set; }
        /// <summary>Details the pre-authentication setting for the application. Pre-authentication enforces that users must authenticate before accessing the app. Passthru does not require authentication. Possible values are: passthru, aadPreAuthentication.</summary>
        public Microsoft.Graph.Beta.Models.ExternalAuthenticationType? ExternalAuthenticationType { get; set; }
        /// <summary>The published external url for the application. For example, https://intranet-contoso.msappproxy.net/.</summary>
        public string ExternalUrl { get; set; }
        /// <summary>The internal url of the application. For example, https://intranet/.</summary>
        public string InternalUrl { get; set; }
        /// <summary>Indicates whether backend SSL certificate validation is enabled for the application. For all new Application Proxy apps, the property will be set to true by default. For all existing apps, the property will be set to false.</summary>
        public bool? IsBackendCertificateValidationEnabled { get; set; }
        /// <summary>Indicates if the HTTPOnly cookie flag should be set in the HTTP response headers. Set this value to true to have Application Proxy cookies include the HTTPOnly flag in the HTTP response headers. If using Remote Desktop Services, set this value to False. Default value is false.</summary>
        public bool? IsHttpOnlyCookieEnabled { get; set; }
        /// <summary>Indicates if the application is currently being published via Application Proxy or not. This is pre-set by the system. Read-only.</summary>
        public bool? IsOnPremPublishingEnabled { get; set; }
        /// <summary>Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can&apos;t share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.</summary>
        public bool? IsPersistentCookieEnabled { get; set; }
        /// <summary>Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.</summary>
        public bool? IsSecureCookieEnabled { get; set; }
        /// <summary>Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.</summary>
        public bool? IsTranslateHostHeaderEnabled { get; set; }
        /// <summary>Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don&apos;t use custom domains. For more information, see Link translation with Application Proxy. Default value is false.</summary>
        public bool? IsTranslateLinksInBodyEnabled { get; set; }
        /// <summary>Represents the single sign-on configuration for the on-premises application.</summary>
        public OnPremisesPublishingSingleSignOn SingleSignOnSettings { get; set; }
        /// <summary>The useAlternateUrlForTranslationAndRedirect property</summary>
        public bool? UseAlternateUrlForTranslationAndRedirect { get; set; }
        /// <summary>Details of the certificate associated with the application when a custom domain is in use. null when using the default domain. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.VerifiedCustomDomainCertificatesMetadata VerifiedCustomDomainCertificatesMetadata { get; set; }
        /// <summary>The associated key credential for the custom domain used.</summary>
        public KeyCredential VerifiedCustomDomainKeyCredential { get; set; }
        /// <summary>The associated password credential for the custom domain used.</summary>
        public PasswordCredential VerifiedCustomDomainPasswordCredential { get; set; }
        /// <summary>
        /// Instantiates a new onPremisesPublishing and sets the default values.
        /// </summary>
        public OnPremisesPublishing() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OnPremisesPublishing CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesPublishing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alternateUrl", n => { AlternateUrl = n.GetStringValue(); } },
                {"applicationServerTimeout", n => { ApplicationServerTimeout = n.GetStringValue(); } },
                {"applicationType", n => { ApplicationType = n.GetStringValue(); } },
                {"externalAuthenticationType", n => { ExternalAuthenticationType = n.GetEnumValue<ExternalAuthenticationType>(); } },
                {"externalUrl", n => { ExternalUrl = n.GetStringValue(); } },
                {"internalUrl", n => { InternalUrl = n.GetStringValue(); } },
                {"isBackendCertificateValidationEnabled", n => { IsBackendCertificateValidationEnabled = n.GetBoolValue(); } },
                {"isHttpOnlyCookieEnabled", n => { IsHttpOnlyCookieEnabled = n.GetBoolValue(); } },
                {"isOnPremPublishingEnabled", n => { IsOnPremPublishingEnabled = n.GetBoolValue(); } },
                {"isPersistentCookieEnabled", n => { IsPersistentCookieEnabled = n.GetBoolValue(); } },
                {"isSecureCookieEnabled", n => { IsSecureCookieEnabled = n.GetBoolValue(); } },
                {"isTranslateHostHeaderEnabled", n => { IsTranslateHostHeaderEnabled = n.GetBoolValue(); } },
                {"isTranslateLinksInBodyEnabled", n => { IsTranslateLinksInBodyEnabled = n.GetBoolValue(); } },
                {"singleSignOnSettings", n => { SingleSignOnSettings = n.GetObjectValue<OnPremisesPublishingSingleSignOn>(OnPremisesPublishingSingleSignOn.CreateFromDiscriminatorValue); } },
                {"useAlternateUrlForTranslationAndRedirect", n => { UseAlternateUrlForTranslationAndRedirect = n.GetBoolValue(); } },
                {"verifiedCustomDomainCertificatesMetadata", n => { VerifiedCustomDomainCertificatesMetadata = n.GetObjectValue<Microsoft.Graph.Beta.Models.VerifiedCustomDomainCertificatesMetadata>(Microsoft.Graph.Beta.Models.VerifiedCustomDomainCertificatesMetadata.CreateFromDiscriminatorValue); } },
                {"verifiedCustomDomainKeyCredential", n => { VerifiedCustomDomainKeyCredential = n.GetObjectValue<KeyCredential>(KeyCredential.CreateFromDiscriminatorValue); } },
                {"verifiedCustomDomainPasswordCredential", n => { VerifiedCustomDomainPasswordCredential = n.GetObjectValue<PasswordCredential>(PasswordCredential.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alternateUrl", AlternateUrl);
            writer.WriteStringValue("applicationServerTimeout", ApplicationServerTimeout);
            writer.WriteStringValue("applicationType", ApplicationType);
            writer.WriteEnumValue<ExternalAuthenticationType>("externalAuthenticationType", ExternalAuthenticationType);
            writer.WriteStringValue("externalUrl", ExternalUrl);
            writer.WriteStringValue("internalUrl", InternalUrl);
            writer.WriteBoolValue("isBackendCertificateValidationEnabled", IsBackendCertificateValidationEnabled);
            writer.WriteBoolValue("isHttpOnlyCookieEnabled", IsHttpOnlyCookieEnabled);
            writer.WriteBoolValue("isOnPremPublishingEnabled", IsOnPremPublishingEnabled);
            writer.WriteBoolValue("isPersistentCookieEnabled", IsPersistentCookieEnabled);
            writer.WriteBoolValue("isSecureCookieEnabled", IsSecureCookieEnabled);
            writer.WriteBoolValue("isTranslateHostHeaderEnabled", IsTranslateHostHeaderEnabled);
            writer.WriteBoolValue("isTranslateLinksInBodyEnabled", IsTranslateLinksInBodyEnabled);
            writer.WriteObjectValue<OnPremisesPublishingSingleSignOn>("singleSignOnSettings", SingleSignOnSettings);
            writer.WriteBoolValue("useAlternateUrlForTranslationAndRedirect", UseAlternateUrlForTranslationAndRedirect);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.VerifiedCustomDomainCertificatesMetadata>("verifiedCustomDomainCertificatesMetadata", VerifiedCustomDomainCertificatesMetadata);
            writer.WriteObjectValue<KeyCredential>("verifiedCustomDomainKeyCredential", VerifiedCustomDomainKeyCredential);
            writer.WriteObjectValue<PasswordCredential>("verifiedCustomDomainPasswordCredential", VerifiedCustomDomainPasswordCredential);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
