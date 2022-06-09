using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OpenIdConnectProvider : IdentityProvider, IParsable {
        /// <summary>After the OIDC provider sends an ID token back to Azure AD, Azure AD needs to be able to map the claims from the received token to the claims that Azure AD recognizes and uses. This complex type captures that mapping. It is a required property.</summary>
        public Microsoft.Graph.Beta.Models.ClaimsMapping ClaimsMapping {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClaimsMapping>(nameof(ClaimsMapping)); }
            set { BackingStore?.Set(nameof(ClaimsMapping), value); }
        }
        /// <summary>The domain hint can be used to skip directly to the sign-in page of the specified identity provider, instead of having the user make a selection among the list of available identity providers.</summary>
        public string DomainHint {
            get { return BackingStore?.Get<string>(nameof(DomainHint)); }
            set { BackingStore?.Set(nameof(DomainHint), value); }
        }
        /// <summary>The URL for the metadata document of the OpenID Connect identity provider. Every OpenID Connect identity provider describes a metadata document that contains most of the information required to perform sign-in. This includes information such as the URLs to use and the location of the service&apos;s public signing keys. The OpenID Connect metadata document is always located at an endpoint that ends in .well-known/openid-configuration . For the OpenID Connect identity provider you are looking to add, you will need to provide the metadata URL. It is a required property and is read only after creation.</summary>
        public string MetadataUrl {
            get { return BackingStore?.Get<string>(nameof(MetadataUrl)); }
            set { BackingStore?.Set(nameof(MetadataUrl), value); }
        }
        /// <summary>The response mode defines the method that should be used to send the data back from the custom identity provider to Azure AD B2C. The following response modes can be used: form_post, query. query response mode means the code or token is returned as a query parameter. form_post response mode is recommended for the best security. The response is transmitted via the HTTP POST method, with the code or token being encoded in the body using the application/x-www-form-urlencoded format. It is a required property.</summary>
        public OpenIdConnectResponseMode? ResponseMode {
            get { return BackingStore?.Get<OpenIdConnectResponseMode?>(nameof(ResponseMode)); }
            set { BackingStore?.Set(nameof(ResponseMode), value); }
        }
        /// <summary>response type describes what kind of information is sent back in the initial call to the authorization_endpoint of the custom identity provider. The following response types can be used: code , id_token , token. It is a required property.</summary>
        public OpenIdConnectResponseTypes? ResponseType {
            get { return BackingStore?.Get<OpenIdConnectResponseTypes?>(nameof(ResponseType)); }
            set { BackingStore?.Set(nameof(ResponseType), value); }
        }
        /// <summary>Scope defines the information and permissions you are looking to gather from your custom identity provider. OpenID Connect requests must contain the openid scope value in order to receive the ID token from the identity provider. Without the ID token, users are not able to sign in to Azure AD B2C using the custom identity provider. Other scopes can be appended separated by space. For more details about the scope limitations see RFC6749 Section 3.3. It is a required property.</summary>
        public string Scope {
            get { return BackingStore?.Get<string>(nameof(Scope)); }
            set { BackingStore?.Set(nameof(Scope), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OpenIdConnectProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OpenIdConnectProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"claimsMapping", n => { ClaimsMapping = n.GetObjectValue<Microsoft.Graph.Beta.Models.ClaimsMapping>(Microsoft.Graph.Beta.Models.ClaimsMapping.CreateFromDiscriminatorValue); } },
                {"domainHint", n => { DomainHint = n.GetStringValue(); } },
                {"metadataUrl", n => { MetadataUrl = n.GetStringValue(); } },
                {"responseMode", n => { ResponseMode = n.GetEnumValue<OpenIdConnectResponseMode>(); } },
                {"responseType", n => { ResponseType = n.GetEnumValue<OpenIdConnectResponseTypes>(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ClaimsMapping>("claimsMapping", ClaimsMapping);
            writer.WriteStringValue("domainHint", DomainHint);
            writer.WriteStringValue("metadataUrl", MetadataUrl);
            writer.WriteEnumValue<OpenIdConnectResponseMode>("responseMode", ResponseMode);
            writer.WriteEnumValue<OpenIdConnectResponseTypes>("responseType", ResponseType);
            writer.WriteStringValue("scope", Scope);
        }
    }
}
