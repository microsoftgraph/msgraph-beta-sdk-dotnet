using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WebApplication : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Home page or landing page of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? HomePageUrl {
            get { return BackingStore?.Get<string?>("homePageUrl"); }
            set { BackingStore?.Set("homePageUrl", value); }
        }
#else
        public string HomePageUrl {
            get { return BackingStore?.Get<string>("homePageUrl"); }
            set { BackingStore?.Set("homePageUrl", value); }
        }
#endif
        /// <summary>Specifies whether this web application can request tokens using the OAuth 2.0 implicit flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.ImplicitGrantSettings? ImplicitGrantSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ImplicitGrantSettings?>("implicitGrantSettings"); }
            set { BackingStore?.Set("implicitGrantSettings", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.ImplicitGrantSettings ImplicitGrantSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ImplicitGrantSettings>("implicitGrantSettings"); }
            set { BackingStore?.Set("implicitGrantSettings", value); }
        }
#endif
        /// <summary>Specifies the URL that will be used by Microsoft&apos;s authorization service to logout an user using front-channel, back-channel or SAML logout protocols.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? LogoutUrl {
            get { return BackingStore?.Get<string?>("logoutUrl"); }
            set { BackingStore?.Set("logoutUrl", value); }
        }
#else
        public string LogoutUrl {
            get { return BackingStore?.Get<string>("logoutUrl"); }
            set { BackingStore?.Set("logoutUrl", value); }
        }
#endif
        /// <summary>The oauth2AllowImplicitFlow property</summary>
        public bool? Oauth2AllowImplicitFlow {
            get { return BackingStore?.Get<bool?>("oauth2AllowImplicitFlow"); }
            set { BackingStore?.Set("oauth2AllowImplicitFlow", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? RedirectUris {
            get { return BackingStore?.Get<List<string>?>("redirectUris"); }
            set { BackingStore?.Set("redirectUris", value); }
        }
#else
        public List<string> RedirectUris {
            get { return BackingStore?.Get<List<string>>("redirectUris"); }
            set { BackingStore?.Set("redirectUris", value); }
        }
#endif
        /// <summary>Specifies the index of the URLs where user tokens are sent for sign-in. This is only valid for applications using SAML.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Beta.Models.RedirectUriSettings>? RedirectUriSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RedirectUriSettings>?>("redirectUriSettings"); }
            set { BackingStore?.Set("redirectUriSettings", value); }
        }
#else
        public List<Microsoft.Graph.Beta.Models.RedirectUriSettings> RedirectUriSettings {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RedirectUriSettings>>("redirectUriSettings"); }
            set { BackingStore?.Set("redirectUriSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new webApplication and sets the default values.
        /// </summary>
        public WebApplication() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"redirectUris", n => { RedirectUris = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"redirectUriSettings", n => { RedirectUriSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RedirectUriSettings>(Microsoft.Graph.Beta.Models.RedirectUriSettings.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("homePageUrl", HomePageUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ImplicitGrantSettings>("implicitGrantSettings", ImplicitGrantSettings);
            writer.WriteStringValue("logoutUrl", LogoutUrl);
            writer.WriteBoolValue("oauth2AllowImplicitFlow", Oauth2AllowImplicitFlow);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("redirectUris", RedirectUris);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RedirectUriSettings>("redirectUriSettings", RedirectUriSettings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
