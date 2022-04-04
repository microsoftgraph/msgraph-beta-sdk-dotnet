using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WebApplication : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Home page or landing page of the application.</summary>
        public string HomePageUrl { get; set; }
        /// <summary>Specifies whether this web application can request tokens using the OAuth 2.0 implicit flow.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ImplicitGrantSettings ImplicitGrantSettings { get; set; }
        /// <summary>Specifies the URL that will be used by Microsoft&apos;s authorization service to logout an user using front-channel, back-channel or SAML logout protocols.</summary>
        public string LogoutUrl { get; set; }
        /// <summary>The oauth2AllowImplicitFlow property</summary>
        public bool? Oauth2AllowImplicitFlow { get; set; }
        /// <summary>Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.</summary>
        public List<string> RedirectUris { get; set; }
        /// <summary>Specifies the index of the URLs where user tokens are sent for sign-in. This is only valid for applications using SAML.</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.RedirectUriSettings> RedirectUriSettings { get; set; }
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"homePageUrl", (o,n) => { (o as WebApplication).HomePageUrl = n.GetStringValue(); } },
                {"implicitGrantSettings", (o,n) => { (o as WebApplication).ImplicitGrantSettings = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ImplicitGrantSettings>(MicrosoftGraphSdk.Models.Microsoft.Graph.ImplicitGrantSettings.CreateFromDiscriminatorValue); } },
                {"logoutUrl", (o,n) => { (o as WebApplication).LogoutUrl = n.GetStringValue(); } },
                {"oauth2AllowImplicitFlow", (o,n) => { (o as WebApplication).Oauth2AllowImplicitFlow = n.GetBoolValue(); } },
                {"redirectUris", (o,n) => { (o as WebApplication).RedirectUris = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"redirectUriSettings", (o,n) => { (o as WebApplication).RedirectUriSettings = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.RedirectUriSettings>(MicrosoftGraphSdk.Models.Microsoft.Graph.RedirectUriSettings.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("homePageUrl", HomePageUrl);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ImplicitGrantSettings>("implicitGrantSettings", ImplicitGrantSettings);
            writer.WriteStringValue("logoutUrl", LogoutUrl);
            writer.WriteBoolValue("oauth2AllowImplicitFlow", Oauth2AllowImplicitFlow);
            writer.WriteCollectionOfPrimitiveValues<string>("redirectUris", RedirectUris);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.RedirectUriSettings>("redirectUriSettings", RedirectUriSettings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
