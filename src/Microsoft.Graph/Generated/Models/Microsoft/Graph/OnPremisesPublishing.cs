using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OnPremisesPublishing : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.</summary>
        public string AlternateUrl { get; set; }
        /// <summary>The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is 'Backend Timeout'. Default value is default.</summary>
        public string ApplicationServerTimeout { get; set; }
        /// <summary>Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.</summary>
        public string ApplicationType { get; set; }
        /// <summary>Details the pre-authentication setting for the application. Pre-authentication enforces that users must authenticate before accessing the app. Passthru does not require authentication. Possible values are: passthru, aadPreAuthentication.</summary>
        public ExternalAuthenticationType? ExternalAuthenticationType { get; set; }
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
        /// <summary>Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can't share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.</summary>
        public bool? IsPersistentCookieEnabled { get; set; }
        /// <summary>Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.</summary>
        public bool? IsSecureCookieEnabled { get; set; }
        /// <summary>Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.</summary>
        public bool? IsTranslateHostHeaderEnabled { get; set; }
        /// <summary>Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don't use custom domains. For more information, see Link translation with Application Proxy. Default value is false.</summary>
        public bool? IsTranslateLinksInBodyEnabled { get; set; }
        /// <summary>Represents the single sign-on configuration for the on-premises application.</summary>
        public OnPremisesPublishingSingleSignOn SingleSignOnSettings { get; set; }
        public bool? UseAlternateUrlForTranslationAndRedirect { get; set; }
        /// <summary>Details of the certificate associated with the application when a custom domain is in use. null when using the default domain. Read-only.</summary>
        public VerifiedCustomDomainCertificatesMetadata VerifiedCustomDomainCertificatesMetadata { get; set; }
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"alternateUrl", (o,n) => { (o as OnPremisesPublishing).AlternateUrl = n.GetStringValue(); } },
                {"applicationServerTimeout", (o,n) => { (o as OnPremisesPublishing).ApplicationServerTimeout = n.GetStringValue(); } },
                {"applicationType", (o,n) => { (o as OnPremisesPublishing).ApplicationType = n.GetStringValue(); } },
                {"externalAuthenticationType", (o,n) => { (o as OnPremisesPublishing).ExternalAuthenticationType = n.GetEnumValue<ExternalAuthenticationType>(); } },
                {"externalUrl", (o,n) => { (o as OnPremisesPublishing).ExternalUrl = n.GetStringValue(); } },
                {"internalUrl", (o,n) => { (o as OnPremisesPublishing).InternalUrl = n.GetStringValue(); } },
                {"isBackendCertificateValidationEnabled", (o,n) => { (o as OnPremisesPublishing).IsBackendCertificateValidationEnabled = n.GetBoolValue(); } },
                {"isHttpOnlyCookieEnabled", (o,n) => { (o as OnPremisesPublishing).IsHttpOnlyCookieEnabled = n.GetBoolValue(); } },
                {"isOnPremPublishingEnabled", (o,n) => { (o as OnPremisesPublishing).IsOnPremPublishingEnabled = n.GetBoolValue(); } },
                {"isPersistentCookieEnabled", (o,n) => { (o as OnPremisesPublishing).IsPersistentCookieEnabled = n.GetBoolValue(); } },
                {"isSecureCookieEnabled", (o,n) => { (o as OnPremisesPublishing).IsSecureCookieEnabled = n.GetBoolValue(); } },
                {"isTranslateHostHeaderEnabled", (o,n) => { (o as OnPremisesPublishing).IsTranslateHostHeaderEnabled = n.GetBoolValue(); } },
                {"isTranslateLinksInBodyEnabled", (o,n) => { (o as OnPremisesPublishing).IsTranslateLinksInBodyEnabled = n.GetBoolValue(); } },
                {"singleSignOnSettings", (o,n) => { (o as OnPremisesPublishing).SingleSignOnSettings = n.GetObjectValue<OnPremisesPublishingSingleSignOn>(); } },
                {"useAlternateUrlForTranslationAndRedirect", (o,n) => { (o as OnPremisesPublishing).UseAlternateUrlForTranslationAndRedirect = n.GetBoolValue(); } },
                {"verifiedCustomDomainCertificatesMetadata", (o,n) => { (o as OnPremisesPublishing).VerifiedCustomDomainCertificatesMetadata = n.GetObjectValue<VerifiedCustomDomainCertificatesMetadata>(); } },
                {"verifiedCustomDomainKeyCredential", (o,n) => { (o as OnPremisesPublishing).VerifiedCustomDomainKeyCredential = n.GetObjectValue<KeyCredential>(); } },
                {"verifiedCustomDomainPasswordCredential", (o,n) => { (o as OnPremisesPublishing).VerifiedCustomDomainPasswordCredential = n.GetObjectValue<PasswordCredential>(); } },
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
            writer.WriteObjectValue<VerifiedCustomDomainCertificatesMetadata>("verifiedCustomDomainCertificatesMetadata", VerifiedCustomDomainCertificatesMetadata);
            writer.WriteObjectValue<KeyCredential>("verifiedCustomDomainKeyCredential", VerifiedCustomDomainKeyCredential);
            writer.WriteObjectValue<PasswordCredential>("verifiedCustomDomainPasswordCredential", VerifiedCustomDomainPasswordCredential);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
