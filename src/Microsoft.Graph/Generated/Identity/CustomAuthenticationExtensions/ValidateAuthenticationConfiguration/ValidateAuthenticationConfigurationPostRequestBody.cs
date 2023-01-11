using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Identity.CustomAuthenticationExtensions.ValidateAuthenticationConfiguration {
    public class ValidateAuthenticationConfigurationPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The authenticationConfiguration property</summary>
        public CustomExtensionAuthenticationConfiguration AuthenticationConfiguration {
            get { return BackingStore?.Get<CustomExtensionAuthenticationConfiguration>("authenticationConfiguration"); }
            set { BackingStore?.Set("authenticationConfiguration", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The endpointConfiguration property</summary>
        public CustomExtensionEndpointConfiguration EndpointConfiguration {
            get { return BackingStore?.Get<CustomExtensionEndpointConfiguration>("endpointConfiguration"); }
            set { BackingStore?.Set("endpointConfiguration", value); }
        }
        /// <summary>
        /// Instantiates a new validateAuthenticationConfigurationPostRequestBody and sets the default values.
        /// </summary>
        public ValidateAuthenticationConfigurationPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ValidateAuthenticationConfigurationPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidateAuthenticationConfigurationPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authenticationConfiguration", n => { AuthenticationConfiguration = n.GetObjectValue<CustomExtensionAuthenticationConfiguration>(CustomExtensionAuthenticationConfiguration.CreateFromDiscriminatorValue); } },
                {"endpointConfiguration", n => { EndpointConfiguration = n.GetObjectValue<CustomExtensionEndpointConfiguration>(CustomExtensionEndpointConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CustomExtensionAuthenticationConfiguration>("authenticationConfiguration", AuthenticationConfiguration);
            writer.WriteObjectValue<CustomExtensionEndpointConfiguration>("endpointConfiguration", EndpointConfiguration);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
