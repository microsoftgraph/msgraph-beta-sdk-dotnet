using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SamlOrWsFedProvider : IdentityProviderBase, IParsable {
        /// <summary>Issuer URI of the federation server.</summary>
        public string IssuerUri { get; set; }
        /// <summary>URI of the metadata exchange endpoint used for authentication from rich client applications.</summary>
        public string MetadataExchangeUri { get; set; }
        /// <summary>URI that web-based clients are directed to when signing in to Azure Active Directory (Azure AD) services.</summary>
        public string PassiveSignInUri { get; set; }
        /// <summary>Preferred authentication protocol. Supported values include saml or wsfed.</summary>
        public AuthenticationProtocol? PreferredAuthenticationProtocol { get; set; }
        /// <summary>Current certificate used to sign tokens passed to the Microsoft identity platform. The certificate is formatted as a Base64 encoded string of the public portion of the federated IdP's token signing certificate and must be compatible with the X509Certificate2 class.   This property is used in the following scenarios:  if a rollover is required outside of the autorollover update a new federation service is being set up  if the new token signing certificate isn't present in the federation properties after the federation service certificate has been updated.   Azure AD updates certificates via an autorollover process in which it attempts to retrieve a new certificate from the federation service metadata, 30 days before expiry of the current certificate. If a new certificate isn't available, Azure AD monitors the metadata daily and will update the federation settings for the domain when a new certificate is available.</summary>
        public string SigningCertificate { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"issuerUri", (o,n) => { (o as SamlOrWsFedProvider).IssuerUri = n.GetStringValue(); } },
                {"metadataExchangeUri", (o,n) => { (o as SamlOrWsFedProvider).MetadataExchangeUri = n.GetStringValue(); } },
                {"passiveSignInUri", (o,n) => { (o as SamlOrWsFedProvider).PassiveSignInUri = n.GetStringValue(); } },
                {"preferredAuthenticationProtocol", (o,n) => { (o as SamlOrWsFedProvider).PreferredAuthenticationProtocol = n.GetEnumValue<AuthenticationProtocol>(); } },
                {"signingCertificate", (o,n) => { (o as SamlOrWsFedProvider).SigningCertificate = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("issuerUri", IssuerUri);
            writer.WriteStringValue("metadataExchangeUri", MetadataExchangeUri);
            writer.WriteStringValue("passiveSignInUri", PassiveSignInUri);
            writer.WriteEnumValue<AuthenticationProtocol>("preferredAuthenticationProtocol", PreferredAuthenticationProtocol);
            writer.WriteStringValue("signingCertificate", SigningCertificate);
        }
    }
}
