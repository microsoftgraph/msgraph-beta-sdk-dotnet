using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftAuthenticatorFeatureSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Determines whether the user&apos;s Authenticator app will show them the client app they are signing into.</summary>
        public AuthenticationMethodFeatureConfiguration DisplayAppInformationRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration>("displayAppInformationRequiredState"); }
            set { BackingStore?.Set("displayAppInformationRequiredState", value); }
        }
        /// <summary>Determines whether the user&apos;s Authenticator app will show them the geographic location of where the authentication request originated from.</summary>
        public AuthenticationMethodFeatureConfiguration DisplayLocationInformationRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration>("displayLocationInformationRequiredState"); }
            set { BackingStore?.Set("displayLocationInformationRequiredState", value); }
        }
        /// <summary>Specifies whether the user needs to enter a number in the Authenticator app from the login screen to complete their login. Value is ignored for phone sign-in notifications.</summary>
        public AuthenticationMethodFeatureConfiguration NumberMatchingRequiredState {
            get { return BackingStore?.Get<AuthenticationMethodFeatureConfiguration>("numberMatchingRequiredState"); }
            set { BackingStore?.Set("numberMatchingRequiredState", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new microsoftAuthenticatorFeatureSettings and sets the default values.
        /// </summary>
        public MicrosoftAuthenticatorFeatureSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MicrosoftAuthenticatorFeatureSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftAuthenticatorFeatureSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayAppInformationRequiredState", n => { DisplayAppInformationRequiredState = n.GetObjectValue<AuthenticationMethodFeatureConfiguration>(AuthenticationMethodFeatureConfiguration.CreateFromDiscriminatorValue); } },
                {"displayLocationInformationRequiredState", n => { DisplayLocationInformationRequiredState = n.GetObjectValue<AuthenticationMethodFeatureConfiguration>(AuthenticationMethodFeatureConfiguration.CreateFromDiscriminatorValue); } },
                {"numberMatchingRequiredState", n => { NumberMatchingRequiredState = n.GetObjectValue<AuthenticationMethodFeatureConfiguration>(AuthenticationMethodFeatureConfiguration.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AuthenticationMethodFeatureConfiguration>("displayAppInformationRequiredState", DisplayAppInformationRequiredState);
            writer.WriteObjectValue<AuthenticationMethodFeatureConfiguration>("displayLocationInformationRequiredState", DisplayLocationInformationRequiredState);
            writer.WriteObjectValue<AuthenticationMethodFeatureConfiguration>("numberMatchingRequiredState", NumberMatchingRequiredState);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
