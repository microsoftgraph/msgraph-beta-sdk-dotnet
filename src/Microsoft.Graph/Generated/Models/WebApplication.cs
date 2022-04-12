using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WebApplication : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Home page or landing page of the application.</summary>
        public string HomePageUrl { get; set; }
        /// <summary>Specifies whether this web application can request tokens using the OAuth 2.0 implicit flow.</summary>
        public Microsoft.Graph.Beta.Models.ImplicitGrantSettings ImplicitGrantSettings { get; set; }
        /// <summary>Specifies the URL that will be used by Microsoft&apos;s authorization service to logout an user using front-channel, back-channel or SAML logout protocols.</summary>
        public string LogoutUrl { get; set; }
        /// <summary>The oauth2AllowImplicitFlow property</summary>
        public bool? Oauth2AllowImplicitFlow { get; set; }
        /// <summary>Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.</summary>
        public List<string> RedirectUris { get; set; }
        /// <summary>Specifies the index of the URLs where user tokens are sent for sign-in. This is only valid for applications using SAML.</summary>
        public List<Microsoft.Graph.Beta.Models.RedirectUriSettings> RedirectUriSettings { get; set; }
        /// <summary>
        /// Instantiates a new webApplication and sets the default values.
        /// </summary>
        public WebApplication() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WebApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"homePageUrl", n => { HomePageUrl = n.GetStringValue(); } },
                {"implicitGrantSettings", n => { ImplicitGrantSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.ImplicitGrantSettings>(Microsoft.Graph.Beta.Models.ImplicitGrantSettings.CreateFromDiscriminatorValue); } },
                {"logoutUrl", n => { LogoutUrl = n.GetStringValue(); } },
                {"oauth2AllowImplicitFlow", n => { Oauth2AllowImplicitFlow = n.GetBoolValue(); } },
                {"redirectUris", n => { RedirectUris = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"redirectUriSettings", n => { RedirectUriSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RedirectUriSettings>(Microsoft.Graph.Beta.Models.RedirectUriSettings.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("homePageUrl", HomePageUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ImplicitGrantSettings>("implicitGrantSettings", ImplicitGrantSettings);
            writer.WriteStringValue("logoutUrl", LogoutUrl);
            writer.WriteBoolValue("oauth2AllowImplicitFlow", Oauth2AllowImplicitFlow);
            writer.WriteCollectionOfPrimitiveValues<string>("redirectUris", RedirectUris);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RedirectUriSettings>("redirectUriSettings", RedirectUriSettings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
